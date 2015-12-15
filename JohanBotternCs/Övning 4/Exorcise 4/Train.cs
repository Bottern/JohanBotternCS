using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Train
    {
        private int numberOfSeats;
        private int numberOfWagons;
        private string color;
        private int numberOfDoors;
        private int numberOfWheels;
        private int numberOfWindows;
        private bool isItInMotion;
        private bool isThereAServingWagon;
        private double weight;
        private double length;
        private int torque;
        private static int instanceCount;

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set
            {   if (value > 1000)
                numberOfSeats = value;
                else throw new Exception("Thats a very tiny train, invest immediately");
            }
        }
        public int NumberOfWagons
        {
            get { return numberOfWagons; }
            set
            {
                if (value > 5)
                    numberOfWagons = value;
                else throw new Exception("Thats a very tiny train, inveest immediately");
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (value[0].ToString().ToUpper() == value[0].ToString())
                    color = value;
                else throw new Exception("Has to start with a capital letter");
            }
        }
        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {   if (value > 10)
                    numberOfDoors = value;
                else throw new Exception("Thats a very tiny trainm invest immediately");
            }
        }
        public int NumberOfWheels
        {
         get
            {
                return numberOfWheels;
            }
         set
            { if (value > 40)
                    value = numberOfWheels;
                else throw new Exception("Thats a very tiny train, invest immediately");
            }
        }
        public int NumberOfWindows
        {
            get
            {
                return numberOfWindows;
            }
            set
            { if (value > 50)
                    value = numberOfWindows;
                else throw new Exception("Thats a very tiny train, invest immediately");
            }

        }
        public bool IsItInMotion
        {
            get
            {
                return isItInMotion;
            }
            set
            {
                isItInMotion = value;
            }
        }
        public bool IsThereAServingWagon
        {
            get
            {
                return isThereAServingWagon;
            }
            set
            {
                isThereAServingWagon = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            { if (value > 20000)
                    value = weight;
                else throw new Exception("Thats a very tiny train, invest immediately");
            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            { if (value > 300)
                    length = value;
                else throw new Exception("This is a very tiny train, invest immiedately");
            }
        }
        public static int InstanceCount
        {
            get { return instanceCount; }
        }

        public Train()
        {
            NumberOfSeats = 1200;
            NumberOfWagons = 15;
            Color = "Black";
            NumberOfDoors = 30;
            NumberOfWheels = 60;
            NumberOfWindows = 120;
            IsItInMotion = true;
            IsThereAServingWagon = true;
            Weight = 12568.45;
            Length = 850;
            instanceCount++;
        }
        public Train(int numberOfDoors, double length, string color, bool isItInMotion)
        {
            NumberOfDoors = numberOfDoors;
            Length = length;
            Color = color;
            isItInMotion = true;
            instanceCount++;
        }
        public Train(int numberOfWindows, double weight, bool isThereAServingWagon)
        {
            NumberOfWindows = numberOfWindows;
            Weight = weight;
            IsThereAServingWagon = true;
        }

        static Train ()
        {
            instanceCount = 0;
        }

        public override string ToString()
        { 
            string status = "";
            string newStatus = "";
            if (IsItInMotion)
                status = "in motion";
            else status = "not in motion";
            if (IsThereAServingWagon)
                newStatus = "there is a servingwagon";
            else newStatus = "there isnt a servingwagon";

            return $"NumberOfSeats {NumberOfSeats}, NumberOfWagons {NumberOfWagons}, Color {Color}, NumberOfDoors {NumberOfDoors}, NumberOfWheels {NumberOfWheels}, NumberOfWindows {NumberOfWindows}, Train is {status}, Train has {newStatus}, Weight {Weight}, Length {Length}, Torque {torque}, InstanceCunt {InstanceCount}";
        }
    }
}
