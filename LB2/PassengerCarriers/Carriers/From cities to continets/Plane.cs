using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class Plane: PassengerCarrier
    {
        public Plane()
        {
            PricePrioriti = pricePrioriti.high;
            TimePrioriti = timePrioriti.quickly;
            ComfortLevel = comfortLevel.high;
        }
        public override string Info()
        {
            return "This type of carriers is Plane!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Plane";
            }
            return Title;
        }
    }
}
