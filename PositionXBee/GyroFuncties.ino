byte Read  = 0B10000000;
byte Write = 0B00000000;
byte Z_L;
byte Z_H;

byte ReadRegister(byte Address){
  byte result = 0;
  digitalWrite(ncsGyro, LOW); 
  SPI.transfer(Read | Address);
  result = SPI.transfer(0x00);
  digitalWrite(ncsGyro, HIGH);
return(result);  
}

void WriteRegister(byte Address, byte Value){
  digitalWrite(ncsGyro, LOW);
  SPI.transfer(Write | Address);
  SPI.transfer(Value);
  digitalWrite(ncsGyro, HIGH);
}

void ReadZ(){                                 //Read value gyro
Z_L = ReadRegister(OUT_Z_L);
Z_H = ReadRegister(OUT_Z_H);
z = (Z_H <<8 | Z_L);
gz=(double(z)-cal)*0.07;                      //Decrease with calibration variable and convert to DPS (0.07)
}

void calibrateGyro(int aantal){               //Calibration function
  float sumZ = 0;
  for (int i=0;i<aantal;i++){                 //Read value 1000 times and count them up
    ReadZ();
    sumZ += z;
  }
  cal=sumZ/aantal;                            //Take average of 1000 values
}

int setupL3GD20H()
{
  WriteRegister(CTRL_REG1,0B00001100);        //Power on, Z enabled, X and Y not enabled
  WriteRegister(CTRL_REG4,0B00110000);        //2000dps
}

