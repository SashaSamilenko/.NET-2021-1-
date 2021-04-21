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
        beetwenContinents,
        beetwenPlanets
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
    internal enum comfortLevel
    {
        low,
        middle,
        high
    }
    internal class Trip
    {
        internal typeOfTrip TypeTrip { get; set; }
        internal pricePrioriti PrioritiOfPrice{get;set;}
        internal timePrioriti TimeP { get; set; }
    }
}
