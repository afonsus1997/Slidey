#pragma once

#define INA 10
#define INB 9
#define pot A0

#define defspeed 255
#define speed15 255
#define speed5 255

#define changeThresh 10
#define debounce 1
#define potMillisThresh 100

int lastPos;
int cont = 0;
int potMillis = 0;
int interReading;

int connected = 0;

void sendData(String out) {
		Serial.print(out);
}

void runMotor(char dir, int speed){
  switch (dir){
    case 'u':
      analogWrite(INA, speed);
      analogWrite(INB, 0);
      break;
    case 'd':
      analogWrite(INB, speed);
      analogWrite(INA, 0);
     break;
    case 's':
      analogWrite(INA, 0);
      analogWrite(INB, 0);
      break;
    default:
    break;
  }
}

void stopMotor(){
  runMotor('s', 0);
}

int readPot(){
  int read = analogRead(pot);
  int conv = map(read, 0, 1024, 0, 100);
  return conv;
}

void savePos(){
  lastPos = readPot();
  //Serial.print("Saved pos "); Serial.println(lastPos);
}
void currentPos(){
  int current = readPot();
  //Serial.print("Current pos "); Serial.println(current);
}

int getCurrentPos(){
  return readPot();
  
}
void setPos(int pos){
  //int conv = map(pos, 0, 100, 0, 1024);
	int read = readPot(); interReading = read;
  while(abs(readPot()-pos) >= 2){
    
	  interReading = read;
    Serial.print("Current pos "); Serial.println(read);
    read = readPot();
	if (abs(read - interReading) < 30) {
		int dif = abs(pos - read);
		int speed = defspeed;
		if (dif <= 15) { speed = speed15; }
		if (dif <= 5) { speed = speed5; }

		if (pos > read) {
			//tem de subir
			runMotor('u', speed);
		}
		else if (pos<read && read != 99) {
			//tem de descer
			runMotor('d', speed);
		}
		else {
			stopMotor();
		}
	}
	else {

	}
    
  }
  stopMotor();
  savePos();
  
}


void checkPot() {
	if (connected == 1) {
		int potReading = readPot();
		int currentMillis = millis();
		//Serial.println(millis() - potMillis);
		if (abs(potReading - lastPos) <= changeThresh && abs(potReading - lastPos) >= debounce && (millis() - potMillis) >= potMillisThresh) {
			//send new value
			//String out = String(cont) + " - S1" + String(potReading); cont++;
			String out = "S1" + String(potReading) + '\n';
			sendData(out);
			lastPos = potReading;
			potMillis = millis();
		}
		//lastPos = potReading;
		//potMillis = millis();
	}
	
}