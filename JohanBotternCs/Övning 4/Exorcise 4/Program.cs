using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Program
    {
        static void Main(string[] args)
        {
            //carMethod();
            radioMethod();
            //radioMethod2();
            //radioMethod3();
            //libraryMethod();
            //trainMethod();
        }

        private static void trainMethod()
        {
            Train pagatag = new Train() { };
            Train sj = new Train() { NumberOfDoors = 120, Length = 400, Color = "Black", IsItInMotion=true};
            Train shinkansen = new Train() {NumberOfWindows = 70, Weight = 750000, IsThereAServingWagon=true};
        }
        private static void libraryMethod()
        {
                    Library library1 = new Library() { NumberOfBooks = 700, IsThereAFireplace = true };
                    Library library2 = new Library() { NumberOfBookshelves = 5.5, Furniture = "Chesterfield", GenreOFBooks = "Fantasy", IsThereAFireplace = true };

                    Console.WriteLine(library1);
                    Console.WriteLine(library2);
        }
        private static void radioMethod3()
                {
                    // Uppgift 5

                    Radio sonos = new Radio() { Volume = 10, Frequency = 103.45, IsItOn = true };
                    Radio bowers = new Radio() { Volume = 30, Frequency = 106.1, IsItOn = true };
                    Radio wilkins = new Radio() { Volume = 2, Frequency = 88.99, IsItOn = false };

                    Console.WriteLine(sonos);
                    Console.WriteLine(bowers);
                    Console.WriteLine(wilkins);
                }
        private static void radioMethod2()
        {
            // Uppgift 3

            Radio phillips = new Radio(25, 100.045);
            Console.WriteLine(phillips);
        }
        private static void radioMethod()
        {
            // Uppgift 2

            Radio denon = null;
            Radio sony = null;

            try
            {
                denon = new Radio(15, false, 90.5);
                sony = new Radio(5, true, 104.8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(denon);
            Console.WriteLine(sony);

            radioMethod3();
        }       
        private static void carMethod()
        {
            // Uppgift 1
            Car chrysler = null;
            Car toyota = null;
            Car corvette = null;
            try
            {
                chrysler = new Car("Chrysler", 5, "red", "combi");
                toyota = new Car("Toyota", 4, "white", "cupe");
                corvette = new Car("Corvette", 6, "blue", "cupe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // När jag skrev ut fel så dog först progremmet sen använder jag mig av try catch för att skriva ut exception message i konsolen istället.
            Console.WriteLine(chrysler);
            Console.WriteLine(toyota);
            Console.WriteLine(corvette);
        }
    }
}