void positieUpdate(){
  UpdatePointer();                          //Read value of laser motion sensor
  ReadZ();                                  //Read value of gyro
  dt = (micros()-time);                     //Save time difference
  time = micros();                          //Reset timer
  hoek = hoek+((dt*gz)/1000000);            //Integrate rotational speed to angle
  hoekrad = (hoek*71)/4068;                 //from degrees to radians
  x=x+((dy*2.54/CPI)*-sin(hoekrad))+((dx*2.54/CPI)*cos(hoekrad)); //Calculate X 
  y=y+((dy*2.54/CPI)*cos(hoekrad))+((dx*2.54/CPI)*sin(hoekrad));  //Calculate Y
}

void doorsturen(){
  sendx=int(x*100);
  sendy=int(y*100);
  buffer[0] = sendx >> 8;
  buffer[1] = sendx & 255;
  buffer[2] = sendy >> 8;
  buffer[3] = sendy & 255;
  xbee.write(buffer,4); 
}

void reset(){
  x = 0;
  y = 0;
  hoek=0;
}





