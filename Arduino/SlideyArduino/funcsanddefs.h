#pragma once




void sendData() {
	int x = 1;
	String y = "S1";
	
	while (true)
	{
		y = "S1" + String(x);
		Serial.println(y);
		y = "";
		if (x == 100) {
			x = 1;
		}
		else
		{
			x++;
		}
		delay(500);
	}
	
	
}