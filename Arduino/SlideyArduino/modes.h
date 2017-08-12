void serialMode(){
	if (Serial.available() > 0 && connected == 0) {
		//Serial.flush();
		String in = Serial.readString();
		//Serial.println(in);
		if (in == "CR" || in == "CR\n") {
			delay(10);
			Serial.print("ACK\n");
			//sendData("ACK");

			connected = 1;
		}
	}

	else if(Serial.available() > 0 && connected == 1){
		//int x = in.toInt();//Serial.parseInt();
		String in = Serial.readString();
		Serial.println(in);
		if (in[0] == 'S' && in[1] == '1') {
			in = in.substring(2, 5);
			int x = in.toInt();
			Serial.println(x);



			if (x != 0 && x != getCurrentPos() && x <= 99 && x >= 0) {
				Serial.print("Going to "); Serial.println(x);
				setPos(x);
			}
			else {
				currentPos();
			}
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
