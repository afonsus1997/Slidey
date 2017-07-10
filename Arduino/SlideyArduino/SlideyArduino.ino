/*
 Name:		SlideyArduino.ino
 Created:	7/10/2017 10:14:41 AM
 Author:	Afonso Muralha
*/

#include "funcsanddefs.h"

// the setup function runs once when you press reset or power the board
void setup() {
	Serial.begin(9600);
	sendData();

}

// the loop function runs over and over again until power down or reset
void loop() {
  
}


void sendData();

