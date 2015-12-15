using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Car
   
    {
        private string brand;
        private int numberOfGears;
        private string color;
        private string type;

        
        public string Brand        
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }
        public int NumberOfGears
        {
            get
            {
                return numberOfGears;
            }
            set
            {
                numberOfGears = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "combi" || value == "cupe")
                    type = value;
                else throw new Exception("Only combi or cupe is available");
            }
        }

        public Car(string brand, int numberOfGears, string color, string type)
        {
            Brand = brand;
            NumberOfGears = numberOfGears;
            Color = color;
            Type = type;
        }

        public override string ToString()
        {
            return $"brand {brand}, numberOfGears {numberOfGears} , color {color} , type {type}";
        }
    }
}
