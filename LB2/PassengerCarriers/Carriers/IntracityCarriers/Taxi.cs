using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    class Taxi: PassengerCarrier
    {
        public Taxi()
        {
            PricePrioriti = pricePrioriti.high;
            TimePrioriti = timePrioriti.quickly;
        }
        public override string Info()
        {
            return "This type of carriers is Taxi!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Taxi";
            }
            return Title;
        }
    }
}
