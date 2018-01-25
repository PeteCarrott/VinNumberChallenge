using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Vin Number: ");
            var vinNumber = Console.ReadLine();

            var vin = new Vin(vinNumber);
            var checker = new Checker(vin);

            if (checker.IsCoveredUnderWarranty())
            {
                if (vin.VehicleCode == "HE80Z")
                {
                    Console.WriteLine("The Denati Company has had a recall on several cars and yours is one of them. It appears that you own the Hyper Elon Sport, and you are entitled to new underbody aluminum reference plates at a cost of €3000");
                }
                else if (vin.VehicleCode == "JB70Z")
                {
                    Console.WriteLine("The Denati Company has had a recall on several cars and yours is one of them. It appears that you own the James Bond Galore, and you are entitled to 4 new archanoid valves, each at a cost of €9.99.");
                }
            }
            else
            {
                Console.WriteLine("Unfortunately you are not covered under warranty");
            }
        }
    }
}
