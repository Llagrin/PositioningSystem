#include <Positie.h>
#include "Wire.h"

POSITIE pos;
double hoek,x=0,y=0;
int dy=0;

void setup()
{
  Wire.begin();
  Serial.begin(19200);  
}
void loop()
{
  pos.allesLezen(x,y,hoek,dy);
  Serial.print(hoek);
  Serial.print("\t");
  Serial.print(x);
  Serial.print("\t");
  Serial.print(y);
  Serial.print("\t");
  Serial.println(dy);
}
