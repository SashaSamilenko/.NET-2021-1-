using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class Train:PassengerCarrier
    {
        public override string Info() 
        {
            return "This type of carriers is Train!"; 
        }
        public override string GetTitle()
        {
            if (Title == null)
            {
                Title = "Train";
            }
            return Title;
        }
    }
}
