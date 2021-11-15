using System;

namespace Assignments
{
    public static class Assignment1
    {
        #region Info

        // https://www.calculateme.com/gas-mileage/us-mpg-to-liters-per-100-km

        #endregion Info

        private static double USGallon = 3.785411784;  // Liters
        private static double Mile = 1.609344;         // Kilometers

        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "Please choose one of the following options and press Enter:\n\n" +
                    "1. Temperature conversion from Fahrenheit to Celsius.\n" +
                    "2. Temperature conversion from Celsius to Fahrenheit.\n" +
                    "3. Temperature comparison between Fahrenheit and Celsius.\n" +
                    "4. Fuel conversion from  Miles per Gallon to Litres per 100 Km.\n" +
                    "5. Fuel conversion from Litres per 100 Km to Miles per Gallon. \n" +
                    "0. Exit \n");

                Console.Write("Your choice (1-5): ");

                var chosenMenuOption = Console.ReadLine();

                if (chosenMenuOption == "0")
                {
                    break;
                }

                switch (chosenMenuOption)
                {
                    case "1":
                        TemperatureFtoC();
                        break;

                    case "2":
                        TemperatureCtoF();
                        break;

                    case "3":
                        CompareTemperatures();
                        break;

                    case "4":
                        FuelConsumptionMpGtoEU();
                        break;

                    case "5":
                        FuelConsumptionEUtoMpG();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter number between 0 and 5");
                        break;
                }

                Console.Write("Press any key to continue... ");
                Console.ReadKey();
            }
        }

        private static void FuelConsumptionEUtoMpG()
        {
            Console.Write("Please enter litters per 100 km:");

            if (double.TryParse(Console.ReadLine(), out double litresPer100K))
            {
                Console.WriteLine($"Miles per galon: {ConvertFuelConsumptionEUtoMpG(litresPer100K)} \n \n");
            }
            else
            {
                Console.WriteLine("Invalid parameter. \n \n");
            }
        }

        private static void FuelConsumptionMpGtoEU()
        {
            Console.Write("Please enter miles per galon:");

            if (double.TryParse(Console.ReadLine(), out double milesPerGalon))
            {
                Console.WriteLine($"Litres per 100 km: {ConvertFuelConsumptionMpGtoEU(milesPerGalon)} \n \n");
            }
            else
            {
                Console.WriteLine("Invalid parameter. \n \n");
            }
        }

        private static void CompareTemperatures()
        {
            bool validInputF = false;
            bool validInputC = false;

            double tempC = 0;
            double tempF = 0;

            Console.WriteLine("Please enter temperature in Fahrenheit:");
            while (validInputF == false)
            {
                try
                {
                    tempF = double.Parse(Console.ReadLine());
                    validInputF = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid temperature in Fahrenheit!");
                }
            }
            Console.WriteLine("Please enter temperature in Celsius:");

            while (validInputC == false)
            {
                try
                {
                    tempC = double.Parse(Console.ReadLine());
                    validInputC = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid temperature in Celsius!");
                }
            }

            double tempFtoC = ConvertFarenheitToCelsius(tempF);
            double tempCtoF = ConvertCelsiusToFarenheit(tempC);

            if (tempF < tempCtoF)
            {
                Console.WriteLine("Temperature in Celsius is bigger.");
            }
            else if (tempCtoF < tempF)
            {
                Console.WriteLine("Temperature in Fahrenheit is bigger.");
            }
            else
            {
                Console.WriteLine("Both temperatures are equal.");
            }

            Console.WriteLine($"Temperature difference in Celsius is: {Math.Abs(tempFtoC - tempC):0.00}");
            Console.WriteLine($"Temperature difference in Fahrenheit is: {Math.Abs(tempF - tempCtoF):0.00}");
        }

        private static void TemperatureCtoF()
        {
            Console.Write("Please enter temperature in Celsius:");

            if (double.TryParse(Console.ReadLine(), out double temp))
            {
                Console.WriteLine($"Temperature in Celsius would be: {ConvertCelsiusToFarenheit(temp)} C. \n \n");
            }
            else
            {
                Console.WriteLine("Invalid temperature. \n \n");
            }
        }

        private static void TemperatureFtoC()
        {
            Console.Write("Please enter temperature in Fahrenheit:");

            if (double.TryParse(Console.ReadLine(), out double temp))
            {
                Console.WriteLine($"Temperature in Celsius would be: {ConvertFarenheitToCelsius(temp)} C. \n \n");
            }
            else
            {
                Console.WriteLine("Invalid temperature. \n \n");
            }
        }

        public static double ConvertFarenheitToCelsius(double temperatureInFarenheit)
        {
            return (temperatureInFarenheit - 32) * 0.5556;
        }

        public static double ConvertCelsiusToFarenheit(double temperatureInCelsius)
        {
            return temperatureInCelsius * 1.8 + 32;
        }

        private static double ConvertFuelConsumptionEUtoMpG(double litersPer100KM)
        {
            return (100 * USGallon) / (Mile * litersPer100KM);
        }

        private static double ConvertFuelConsumptionMpGtoEU(double milesPerGalon)
        {
            return (100 * USGallon) / (Mile * milesPerGalon);
        }
    }
}