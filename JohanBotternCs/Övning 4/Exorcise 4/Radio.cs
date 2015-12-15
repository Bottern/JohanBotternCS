using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Radio
    {
        private int volume;
        private bool isOn;
        private double frequency;
        private static int instanceCount; 

        public int Volume
        {
            get { return volume; }
            set {
                var validVolume = value >= 0 && value <= 30;
                if (validVolume)
                    volume = value;
                else
                    throw new Exception("That not a valid volume");
            }
        }       
        public bool IsItOn
        {
            get { return isOn; }
            set {isOn = value; 
}
        }
        public double Frequency
        {
            get { return frequency; }
            set {
                var frequenceLimits = value >= 87.6 && value <= 106.1;
                if (frequenceLimits) 
                frequency = value;
                else
                    throw new Exception("There is no channel outside the limits of 87.6 and 106.1");
            }
        } 
        public static int InstanceCount
        {
            get { return instanceCount; }
        }
        static Radio()
        {
            instanceCount = 0;
        }
        public Radio()
        {
            Volume = 10;
            //IsItOn = false;
            Frequency = 105;
            instanceCount++;

        } // Uppgift 3
        public Radio(int volume, double frequency) : this()
        {
            Volume = volume;
            Frequency = frequency;
        } // Uppgift 3

        public Radio (int volume, bool isItOn, double frequency):this(volume,frequency)
        {
            //Volume = volume;
            IsItOn = isItOn;
            //Frequency = frequency;
            //instanceCount++;
        }
   
  

      

        public override string ToString()
        {
            string status = "";
            if (isOn)
                status = "on";
            else status = "off";

            return $"Volume {Volume}, Radio is {status}, FrequenceSetting {Frequency} InstanceCount {InstanceCount}";
        }
    }
}
