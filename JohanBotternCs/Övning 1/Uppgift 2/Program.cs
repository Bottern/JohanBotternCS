using System; // Genom att kommentera bort system så existerar ingeting i projektet just då

namespace Uppgift_1
{
    class Program // Genom att skriva fel på class så saknas referens och då kan man inte hitta Console som finns där
    {
        static void Main()// Utan Main har den ingen inkörspunkt
        {
            Console.WriteLine("Hi there!"); // Debuggern ger en info om vad som saknas för att kunna köra
            Console.ReadLine();
        }  // Blir samma som i avsaknaden av semikolonet på linje 9
    }
}
