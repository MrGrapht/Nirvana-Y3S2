#include <SPI.h>  
#include "RF24.h"

RF24 myRadio (7, 8);
byte addresses[][6] = {"0"};

struct package {
  int id;
  int pirState;
};

typedef struct package Package;
Package data;

int soundPin = 0;
//int ledPin = 5;
int sVal;
int pirState = data.pirState;
int soundValue;


byte buf[3];

void setup() {

//  pinMode(ledPin,OUTPUT);
  pinMode(soundPin,INPUT);

  buf[2] = 255;
  
  Serial.begin(9600);
  delay(100);
  myRadio.begin(); 
  myRadio.setChannel(115); 
  myRadio.setPALevel(RF24_PA_MAX);
  myRadio.setDataRate( RF24_250KBPS ) ; 
  myRadio.openReadingPipe(1, addresses[0]);
  myRadio.startListening();
}

int fillBuffer(int soundValue, int pirState) { 
  
  buf[0] = soundValue;
  buf[1] = data.pirState; // Had to access the incoming data directly for this to comm with BT handset

}

void loop() {

  sVal = analogRead(soundPin);

  if ((sVal) < 517) {
//    digitalWrite(ledPin, HIGH);
//    Serial.print("SOUND DETECTED!");
//    Serial.println("Sound Sensor Value: ");
//    Serial.println(sVal); 
    soundValue = HIGH;
  }
  else {
//    digitalWrite(ledPin, LOW);
//    Serial.println("NOTHING...");
//    Serial.println("NOTHING...");
//    Serial.println("NOTHING...");
    soundValue = LOW;
  }
  
  if ( myRadio.available()) {
    while (myRadio.available()) {
      myRadio.read( &data, sizeof(data) );
    }
  }

//    Serial.println(sVal);
//  Serial.print("\nPackage:");
//  Serial.print(data.id);
//  Serial.print("\n");
//  Serial.println(data.text);
//  Serial.print("pirState: ");
//  Serial.println(data.pirState);
//  Serial.print("Motion Digital Read Value: ");
//  Serial.println(data.val);
//  Serial.print("Motion Digital Read BINARY: ");
//  Serial.println(data.val, BIN);
  
  fillBuffer(soundValue,data.pirState);
  Serial.write(buf,3);
  
  delay(100);
}
