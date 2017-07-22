/*
 Name:		SlideyArduino.ino
 Created:	7/10/2017 10:14:41 AM
 Author:	Afonso Muralha
*/

#include "funcsanddefs.h"

// the setup function runs once when you press reset or power the board
void setup() {
  pinMode(pot, INPUT);
  pinMode(INA, OUTPUT);
  pinMode(INB, OUTPUT);
	Serial.begin(9600);
	//sendData();
  savePos();

}

// the loop function runs over and over again until power down or reset
void loop() {
  if(Serial.available()>0){
    int x = Serial.parseInt();
    if(x != -1 || x != 0){
      Serial.print("Going to "); Serial.println(x);
      setPos(x);
    }
    else{
      currentPos();
    }
  }
}


//void sendData();

