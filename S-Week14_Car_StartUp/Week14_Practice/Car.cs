using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_Practice
{
    public class Car
    {
        private string model;
        private int topSpeed;
        private int speed;

        public Car(string model, int topspeed)
        {
            this.model = model;
            this.topSpeed = topspeed;
            this.speed = 0;
        }

        public int Speed
        {
            set { this.speed = value; }
            get { return this.speed;  }
        }
        public string Model
        {
            set { this.model = value; }
            get { return this.model; }
        }


        public void Accelerate(int increaseBy)
        {
            this.speed += increaseBy;
        }

        public void Break()
        {
            this.speed = 0;
        }

        public string GetInfo()
        {
            return $"Car {model}: {speed}/{topSpeed}";
        }
    }
}
