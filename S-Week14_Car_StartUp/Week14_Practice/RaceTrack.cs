using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_Practice
{
    public class RaceTrack
    {
        private string name;
        private List<Car> cars;

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddCar(string model, int topSpeed)
        {
            Car car = new Car(model, topSpeed);

            this.cars.Add(car);
        }

        public Car GetCarByIndex(int index)
        {
            if(index < 0 || index > this.cars.Count())
            {
                return null;
            }
            else
            {
                return this.cars[index];
            }
        }
    }
}
