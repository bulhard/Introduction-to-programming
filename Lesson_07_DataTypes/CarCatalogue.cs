using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_07_DataTypes
{
    public class CarCatalogue
    {
        private List<Car> cars;

        public CarCatalogue()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void RemoveCar(int index)
        {
            cars.RemoveAt(index);
        }

    }
}
