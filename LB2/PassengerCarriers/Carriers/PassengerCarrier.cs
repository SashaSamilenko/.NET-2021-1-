using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public abstract class PassengerCarrier
    {
        protected string Title;
        internal pricePrioriti PricePrioriti { get; set; }
        internal timePrioriti TimePrioriti { get; set; }
        public virtual string Info() { return null; }
        public virtual string GetTitle()
        { 
            Title = null; 
            return null; 
        }
    }
}
