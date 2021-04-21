using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class SpaceCraft:PassengerCarrier
    {
        public SpaceCraft()
        {
            PricePrioriti = pricePrioriti.high;
            TimePrioriti = timePrioriti.quickly;
            ComfortLevel = comfortLevel.middle;
        }
        public override string Info()
        {
            return "This type of carriers is spacecraft!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Spacecraft";
            }
            return Title;
        }
    }
}
