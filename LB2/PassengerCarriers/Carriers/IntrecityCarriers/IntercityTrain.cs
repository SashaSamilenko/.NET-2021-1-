using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class IntercityTrain:Train
    {
        public IntercityTrain()
        {
            PricePrioriti = pricePrioriti.low;
            TimePrioriti = timePrioriti.normally;
        }
        public override string Info()
        {
            return "This type of carriers is intercity train!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Intercity Train";
            }
            return Title;
        }
    }
}
