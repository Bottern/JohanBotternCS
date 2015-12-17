using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning6
{
    class MyDoubleType
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType(double doubleValue)
        {
            this.doubleValue = doubleValue;
        }

        public static MyDoubleType operator + (MyDoubleType inputOne, double inputTwo)
        {
           return new MyDoubleType(inputOne.doubleValue + inputTwo);
        }
        
        public static MyDoubleType operator + (MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return new MyDoubleType( inputOne.doubleValue + inputTwo.doubleValue);
        }
        
        public static MyDoubleType operator - (MyDoubleType inputOne, double inputTwo)
        {
            return new MyDoubleType(inputOne.doubleValue - inputTwo);
        }

        public static MyDoubleType operator - (MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return new MyDoubleType(inputOne.doubleValue - inputTwo.doubleValue);
        }

        public static MyDoubleType operator * (MyDoubleType inputOne, double inputTwo)
        {
            return new MyDoubleType(inputOne.doubleValue * inputTwo);
        }

        public static MyDoubleType operator * (MyDoubleType inputOne, MyDoubleType inpuTwo)
        {
            return new MyDoubleType(inputOne.doubleValue * inpuTwo.doubleValue);
        }
        
        public static MyDoubleType operator / (MyDoubleType inputOne, double inputTwo)
        {
            return new MyDoubleType(inputOne.doubleValue/inputTwo);
        }

        public static MyDoubleType operator / (MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return new MyDoubleType(inputOne.doubleValue / inputTwo.doubleValue);
        }

        public static bool operator < (MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return (inputOne.doubleValue < inputTwo.doubleValue);
        }

        public static bool operator > (MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return (inputOne.doubleValue > inputTwo.doubleValue);
        }

        public static bool operator == (MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return (inputOne.doubleValue == inputTwo.doubleValue);
        }

        public static bool operator != (MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return (inputOne.doubleValue != inputTwo.doubleValue);
        }

        public static bool operator <= (MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return (inputOne.doubleValue <= inputTwo.doubleValue);
        }

        public static bool operator >=(MyDoubleType inputOne, MyDoubleType inputTwo)
        {
            return (inputOne.doubleValue >= inputTwo.doubleValue);
        }

        public override string ToString() => $":{doubleValue}";
        }
}
