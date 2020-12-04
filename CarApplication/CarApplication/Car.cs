using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    public class Car
    {
        private string brand;
        private int maxSpeed;
        private int currentSpeed;

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public void SetMaxSpeed(int speed)
        {
            maxSpeed = speed;
        }

        public void SpeedUp()
        {
            currentSpeed += 7;
            if(currentSpeed > 260)
            {
                currentSpeed = 260;
            }
        }

        public void SlowDown()
        {
            currentSpeed -= 10;
            if(currentSpeed < 0)
            {
                currentSpeed = 0;
            }
        }


        public string GetInfo()
        {
            return $"Speed of my {brand} is {currentSpeed} km/h and its max speed is {maxSpeed} km/h";
        }
    }

}
