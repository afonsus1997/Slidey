#pragma once

#define INA 10
#define INB 9
#define pot A0

#define defspeed 250

int lastPos;



void sendData(String out) {
		Serial.println(out);
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
  Serial.print("Saved pos "); Serial.println(lastPos);
}
void currentPos(){
  int current = readPot();
  Serial.print("Current pos "); Serial.println(current);
}

void setPos(int pos){
  //int conv = map(pos, 0, 100, 0, 1024);
  int read = readPot();
  while(readPot() != pos){
    
    Serial.print("Current pos "); Serial.println(read);
    read = readPot();
    
    if(pos > read){
      //tem de subir
      runMotor('u', defspeed);
    }
    else if(pos<read){
      //tem de descer
      runMotor('d', defspeed);
    }
    else{
      stopMotor();
    }
  }
  stopMotor();
  savePos();
  
}

