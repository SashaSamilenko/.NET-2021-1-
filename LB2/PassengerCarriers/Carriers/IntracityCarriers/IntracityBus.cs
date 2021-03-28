using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class IntracityBus:Bus
    {
        public IntracityBus()
        {
            PricePrioriti = pricePrioriti.low;
            TimePrioriti = timePrioriti.normally;
        }
        public override string Info()
        {
            return "This type of carriers is intracity bus!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Intracity bus";
            }
            return Title;
        }
    }
}
