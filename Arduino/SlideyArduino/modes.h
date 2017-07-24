void serialMode(){
if(Serial.available()>0){
    //Serial.flush();
    
	int x = Serial.parseInt();
    if(x != 0 && x != getCurrentPos() && x <= 99 && x >= 0){
      Serial.print("Going to "); Serial.println(x);
      setPos(x);
    }
    else{
      currentPos();
    }
    
  
}
}

void demo1(){
  for(int i = 1; i<=99; i++){
    setPos(i);
    delay(200);
  }
}


void demo10(){
  for(int i = 1; i<=99; i+=10){
    setPos(i);
    delay(200);
  }
}
