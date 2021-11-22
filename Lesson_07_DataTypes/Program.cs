using System;

namespace Lesson_07_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car
            {
                RegNumber = "123",
                Year = 2010,
                Maker = CarMaker.Ford,
                Model = CarModel.Focus,
                Color = CarColor.Blue
            };

            CarCatalogue catalogue = new CarCatalogue();

            catalogue.AddCar(firstCar);
            
            firstCar.RegNumber = "666";

            catalogue.AddCar(firstCar);
            catalogue.AddCar(firstCar);
            catalogue.AddCar(firstCar);

            catalogue.RemoveCar(0);
        }
    }
}
