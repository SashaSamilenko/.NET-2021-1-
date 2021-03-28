using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class Bus:PassengerCarrier
    {
        public override string Info()
        {
            return "This type of carriers is Bus!";
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Bus";
            }
            return Title;
        }
    }
}
