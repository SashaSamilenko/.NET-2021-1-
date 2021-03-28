using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class IntercountryBus:Bus
    {
        public IntercountryBus()
        {
            PricePrioriti = pricePrioriti.middle;
            TimePrioriti = timePrioriti.normally;
        }
        public override string Info()
        {
            return "This type of carriers is intercountry bus!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Intercountry bus";
            }
            return Title;
        }
    }
}
