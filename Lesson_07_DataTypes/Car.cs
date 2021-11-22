using System;

namespace Lesson_07_DataTypes
{
    public class Car
    {
        private int year;

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 1900 || value > 2050)
                {
                    throw new ArgumentOutOfRangeException("Year should be between 1900 and 2050");
                }
                year = value;
            }
        }


        private string regNumber;
        private string customColor;
        private CarColor color;

        public string RegNumber
        {
            get
            {
                return regNumber;
            }
            set
            {
                if (value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("RegNumber should be less than 10 letters.");
                }
                regNumber = value;
            }
        }

        public CarColor Color
        {
            get => color; 
            set
            {
                if (value != CarColor.Other)
                {
                    CustomColor = string.Empty;
                }
                color = value;
            }
        }

        public string CustomColor
        {
            get => customColor;
            set
            {
                if (Color == CarColor.Other)
                {
                    customColor = value;
                }
            }
        }

        public CarMaker Maker { get; set; }

        public CarModel Model { get; set; }
    }
}