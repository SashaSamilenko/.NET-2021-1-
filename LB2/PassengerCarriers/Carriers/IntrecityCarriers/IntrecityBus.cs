using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class IntrecityBus:Bus
    {
        public IntrecityBus()
        {
            PricePrioriti = pricePrioriti.middle;
            TimePrioriti = timePrioriti.normally;
            ComfortLevel = comfortLevel.middle;
        }
        public override string Info()
        {
            return "This type of carriers is intercity bus!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Intercity bus";
            }
            return Title;
        }
    }
}
