#ifndef Positie_h
#define Positie_h

#include "Arduino.h"
#include "Wire.h"

class POSITIE
{
    public:
        void allesLezen(double &x,double &y, double &hoek, int &dy);
};

#endif
