using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("witaj");
            Console.Write("podaj Swoje imie");
            string imie = Console.ReadLine();

            Console.WriteLine($"Cześć {imie}!!!");
        }
    }
}
