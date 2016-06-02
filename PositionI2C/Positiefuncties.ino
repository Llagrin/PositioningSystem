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

void SendAlles(){
  sendx=x*100;                      //Convert to integer and augment accuracy
  sendy=y*100;
  sendhoek = (hoek*10);
  senddy=dy;
  buffer[0] = sendx >> 8;           //Put values into send buffer
  buffer[1] = sendx & 255;
  buffer[2] = sendy >> 8;
  buffer[3] = sendy & 255;
  buffer[4] = sendhoek >> 8;
  buffer[5] = sendhoek & 255;
  buffer[6] = senddy >> 8;
  buffer[7] = senddy & 255;
  Wire.write(buffer,8);             //Send the buffer
}






