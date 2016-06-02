#include "Arduino.h"
#include "Positie.h"




void POSITIE::allesLezen(double &x,double &y, double &hoek, int &dy){
    Wire.beginTransmission(0x8);
    Wire.write(1);
    Wire.requestFrom(0x8, 8);
    x=(Wire.read() << 8 | Wire.read());
    y=(Wire.read() << 8 | Wire.read());
    hoek=(Wire.read() << 8 | Wire.read());
    dy=(Wire.read() << 8 | Wire.read());
    x=x/100;
    y=y/100;
    hoek=hoek/10;
    Wire.endTransmission();
}

