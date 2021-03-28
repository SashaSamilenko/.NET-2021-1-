using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public enum typeOfTrip
    {
        inCity,
        beetwenCities,
        beetwenCountries,
        beetwenContinents
    }
    public enum pricePrioriti
    {
        low,
        middle,
        high
    }
    public enum timePrioriti
    {
        quickly,
        normally,
        slowly
    }
    internal class Trip
    {
        //internal double Distance { get; set; }
        internal typeOfTrip TypeTrip { get; set; }
        internal pricePrioriti PrioritiOfPrice{get;set;}
        internal timePrioriti TimeP { get; set; }
        internal double VolumeOfBaggage { get; set; }
    }
}
