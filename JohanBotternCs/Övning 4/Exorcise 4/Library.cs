using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Library
    {
        private string furniture;
        private double numberOfBookshelves;
        private string genreOfBooks;
        private int numberOfBooks;
        private bool isThereAFireplace;
        private static int instanceCount;
     
        public int NumberOfBooks

        {
            get { return numberOfBooks; }
            set {
                if (value > 150)
                    numberOfBooks = value;
                else throw new Exception("Not enough books to be considered a library");
                }
        }        
        public string Furniture
        {
            get { return furniture; }
            set {if (value[0].ToString().ToUpper() == value[0].ToString())
                    furniture = value;
                else throw new Exception("Has to start off with a capital letter");
                }
        }      
        public string GenreOFBooks
        {
            get { return genreOfBooks; }
            set { genreOfBooks = value; }
        }
        public double NumberOfBookshelves
        {
            get { return numberOfBookshelves; }
            set { if (value > 4)
                    numberOfBookshelves = value;
                else throw new Exception("Not enough shelves to be considerad a library");
            }
        }
        public bool IsThereAFireplace   
        {
            get { return isThereAFireplace; }
            set { isThereAFireplace = value; }
        }
        public static int InstanceCount
        {
            get { return instanceCount; }
        }

        static Library ()
        {
            instanceCount=0;
        }

        public Library (int numberOfBooks, bool isThereAFireplace )
        {
            NumberOfBooks = numberOfBooks;
            IsThereAFireplace = isThereAFireplace;
            instanceCount++;
        }
        public Library (double numberOfBookshelves, string genreOfBook, string furniture )
        {
            NumberOfBookshelves = numberOfBookshelves;
            GenreOFBooks = genreOfBook;
            Furniture = furniture;
            instanceCount++;
        }
        public Library ()
        {
            NumberOfBooks = 800;
            NumberOfBookshelves = 8.5;
            IsThereAFireplace = true;
            Furniture = "Sofa";
            instanceCount++;
        }
        public override string ToString()
        {
            string status = "";
            if (IsThereAFireplace)
                status = "fireplace";
            else status = "no fireplace";

            return $"Furniture {Furniture}, Numberofbookshelves {NumberOfBookshelves}, NumberOfBooks {NumberOfBooks}, GenreOfBooks {genreOfBooks}, There is {status}, InstanceCount {InstanceCount}";   
        }
    }
}
