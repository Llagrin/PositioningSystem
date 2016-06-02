#include <SPI.h>
#include <avr/pgmspace.h>
#include "L3GD20H.h"
#include <SoftwareSerial.h>
SoftwareSerial xbee(9,10); // RX, TX

const int ncsADNS = 4;                         //Slave select laser motion sensor
const int ncsGyro = A5;                        //Slave select gyro 

volatile byte xydat[4];                        //buffer for reading x and y data
float dx=0,dy=0;                               //Delta X en delta Y
float x=0,y=-75.5;                             //Beginposition robot
int CPI=1502;                                  //Count per Inch

int z;                                         //Variable for raw gyro data
float gz=0;                                    //Variable for gyro data in DPS calibrated
unsigned long time;                            //Variable for time counter
float dt=0;                                    //Variable for delta time
float hoek=0,hoekrad=0;                        //Variables for angle storage in Degrees and Radians
double cal=0;                                  //Calibration value

int sendx=0,sendy=0;                           //Send variables;

void setup() {
  SPI.begin();                                 //Initialize SPI
  SPI.setDataMode(SPI_MODE3);
  SPI.setBitOrder(MSBFIRST);
  SPI.setClockDivider(8);

  pinMode (ncsADNS, OUTPUT);                   //Set Slave Select pins HIGH
  digitalWrite(ncsADNS, HIGH);
  pinMode(ncsGyro, OUTPUT);
  digitalWrite(ncsGyro, HIGH);
  setupL3GD20H();                              //Initialize gyro
  delay(100);

  performStartup();                            //Initialize laser motion sensor
  dispRegisters();
  delay(300);
  
  xbee.begin(38400);                           //Initialize XBee
  Serial.begin(9600);                          //Initialize Serial com with computer
  
  calibrateGyro(1000);                         //Calibrate gyro

  time=millis();                               //Start time counter
}

void loop() {
  positieUpdate();                             //Update position
  doorsturen();
}
