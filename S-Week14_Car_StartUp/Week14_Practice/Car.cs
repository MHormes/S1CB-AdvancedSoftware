using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_Practice
{
    class Car
    {
        private string model;
        private int topSpeed;
        private int speed;

        public void SetModel(string model)
        {
            this.model = model;
        }

        public string GetModel()
        {
            return this.model;
        }

        public void SetTopSpeed(int topSpeed)
        {
            this.topSpeed = topSpeed;
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        public int GetSpeed()
        {
            return this.speed;
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
