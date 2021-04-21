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
            PassengerCarrier myCarrier = SelectionCarrier.Select(typeOfTrip.beetwenCities, pricePrioriti.middle, timePrioriti.normally);
            if (myCarrier != null)
            {
                Console.WriteLine(myCarrier.Info());
                Console.WriteLine($"My carrier is {myCarrier.GetTitle()}");
            }
            Console.ReadKey();
        }
    }
}
