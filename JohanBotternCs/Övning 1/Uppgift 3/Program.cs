using System;

namespace Uppgift_1
{
    class Program // declare a class
    {
        static void Main()
        {
            System.Console.Write("This is text!"); // Literal strings
            System.Console.WriteLine("This is text2!"); // Samma funktion som Write men har inbyggd newline i sig
            Console.WriteLine("SubVal{0}, SubVal{1}, SubVal{2}.", 20,20,20); // Här kan man då lägga in flera strings i en typ av av array med en underkategori för andra, i det här fallet ints.
            Console.ReadLine();
            
        }
    }
}