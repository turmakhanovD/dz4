using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Train train = new Train("Astana - Shymkent", 16, driver, "Volvo Train\nGermany. Berlin\n2018 year");


            Console.WriteLine( train.GetFullInfo());

         
            Console.ReadLine();
        }
    }
}
