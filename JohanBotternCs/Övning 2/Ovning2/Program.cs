using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dJ = 4.6;
            double nas = 4.1;
            double stock = -2.4;
            double mil = -6.7;
            double par = -5.5;
            double[] stockArray = new double[5] { dJ, nas, stock, mil, par };

            Console.WriteLine("Dow Jones sjönk med " + dJ + " procent och Nasdaq med " + nas + " procent. Stockholm " + stock + " procent, Milano " + mil + " procent, Paris " + par + " procent.");

            dJ = 46.56;
            nas = 568.98;
            stock = -656.89;
            mil = -9.45;
            par = 8963354 - 1;
            Console.WriteLine("Dow Jones sjönk med " + dJ + " procent och Nasdaq med " + nas + " procent. Stockholm " + stock + " procent, Milano " + mil + " procent, Paris " + par + " procent.");

            const double PIE = 3.141592654;
            const double PI = 3.14;
            int pii = 3;
            Console.WriteLine("Talet pi är circa " + PIE + " men kan avrundas till " + PI + " och kan lite grovt skrivas som " + pii);

            pii = -4;
            Console.WriteLine("Talet pi är circa " + PIE + " men kan avrundas till " + PI + " och kan lite grovt skrivas som " + pii);

            string name = "Jonas ";
            string city = "Helsingborg ";
            string area = "på Stattena vid Hemköp.";
            Console.WriteLine("Han heter " + name + "och bor i " + city + area);

            name = "Johan";
            city = "Eslöv";
            area = " vid Fridasro";
            Console.WriteLine("Han heter " + name + " och bor i " + city + area);


        }
    }
}
