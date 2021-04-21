using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class IntercountryTrain:Train
    {
        public IntercountryTrain()
        {
            PricePrioriti = pricePrioriti.low;
            TimePrioriti = timePrioriti.normally;
            ComfortLevel = comfortLevel.middle;
        }
        public override string Info()
        {
            return "This type of carriers is intercountry train!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Intercountry Train";
            }
            return Title;
        }
    }
}
