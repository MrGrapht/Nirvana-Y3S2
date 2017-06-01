#include <SPI.h>  
#include "RF24.h"

RF24 myRadio (7, 8);
byte addresses[][6] = {"0"};

struct package {
  int id = 1;
  int pirState;
//  char text[16];
  int val;
};

typedef struct package Package;
Package data;

int ledPin = 5;                 // choose the pin for the LED
int inputPin = 6;               // choose the input pin (for PIR sensor)
int val = 0;                    // variable for reading the pin status
int pirState = LOW;             // we start, assuming no motion detected

 
void setup() {
  pinMode(ledPin, OUTPUT);      // declare LED as output
  pinMode(inputPin, INPUT);     // declare sensor as input
 
  Serial.begin(9600);
  delay(100);
  myRadio.begin();  
  myRadio.setChannel(115); 
  myRadio.setPALevel(RF24_PA_MAX);
  myRadio.setDataRate( RF24_250KBPS ) ; 
  myRadio.openWritingPipe( addresses[0]);
  delay(1000);
}
 
void loop(){
  val = digitalRead(inputPin);  // read input value
  myRadio.write(&data, sizeof(data));

  if (val == HIGH) {            // check if the input is HIGH
    digitalWrite(ledPin, HIGH);  // turn LED ON
    if (pirState == LOW) {
      // we have just turned on
//      Serial.println("Motion detected!");
      // We only want to print on the output change, not state
      pirState = HIGH;
    }
//    data.text[16] = "Motion Detected";
  } 
  else {
    digitalWrite(ledPin, LOW); // turn LED OFF
    if (pirState == HIGH){
      // we have just turned of
//      Serial.println("Motion ended!");
      // We only want to print on the output change, not state
      pirState = LOW;
    }
//    data.text[16] = "Motion Ended";
  }

//  Serial.println(val);
//  Serial.println(val, BIN);
//  Serial.println(data.pirState);
  data.val = val;
  data.pirState = pirState;
  data.id = data.id + 1;   //is this bit necessary?
  delay(100);
}
