#include <SPI.h>  
#include "RF24.h"

RF24 myRadio (7, 8);
byte addresses[][6] = {"0"};

struct package {
  int id;
  int pirState;
//  char text[16];
  int val;
};

typedef struct package Package;
Package data;

int ThermistorPin = 0;
int Vo;
int pirState = data.pirState;
int val;

byte buf[4];

void setup() {

  buf[3] = 255;
  
  Serial.begin(9600);
  delay(100);
  myRadio.begin(); 
  myRadio.setChannel(115); 
  myRadio.setPALevel(RF24_PA_MAX);
  myRadio.setDataRate( RF24_250KBPS ) ; 
  myRadio.openReadingPipe(1, addresses[0]);
  myRadio.startListening();
}

int fillBuffer(int Vo, int pirState) { 
  
  Vo = Vo << 3;
//  pirState = pirState << 3;
  
  buf[0] = lowByte(Vo);
  buf[1] = highByte(Vo);
  buf[2] = data.pirState; // Had to access the incoming data directly for this to comm with BT handset
//  buf[2] = lowByte(pirState);
//  buf[3] = highByte(pirState);
}

void loop() {

  Vo = analogRead(ThermistorPin);

  if ( myRadio.available()) {
    while (myRadio.available()) {
      myRadio.read( &data, sizeof(data) );
    }
  }

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
  
  fillBuffer(Vo,data.pirState);
  Serial.write(buf,4);
  
  delay(100);
}
