using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }


        public string SetMake(string make)
        {
            Make = make;
            return make;
        }

        public string SetModel(string model)
        {
            Model = model;
            return model;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public bool IsSpeeding()
        {
            if (Speed > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Accelerate()
        {
            if(Speed > 90)
            {
                return 100;
            }
            else if (Make == "Ferrari")
            {
                return Speed += 20;
            }
            else
            {
            return Speed += 10;
            }
        }

        public int Brake()
        {
            if (Speed < 7)
            {
                return Speed = 0;
            }
            else if (AutoBrakeActive)
            {
                return Speed /= 2;
            }
            else
            {
                return Speed -= 7;
            }
        }




    }
}
