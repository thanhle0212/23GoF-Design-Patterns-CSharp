using StateSample;

Steak steak = new Steak();

while (steak.GetTemperature() < 165)
{
    steak.Cook();
}
