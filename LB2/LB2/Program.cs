using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerCarriers;

namespace LB2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PassengerCarrier> myCarriers = SelectionCarrier.Select(typeOfTrip.inCity, pricePrioriti.high, timePrioriti.slowly, 100, 100, 100);
            foreach (PassengerCarrier carrier in myCarriers)
            {
                Console.WriteLine(carrier.Info());
                Console.WriteLine($"My carrier is {carrier.GetTitle()}");
            }
            Console.ReadKey();
        }
    }
}
