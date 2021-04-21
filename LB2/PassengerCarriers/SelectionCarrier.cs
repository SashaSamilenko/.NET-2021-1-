using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    static public class SelectionCarrier
    {
        private static List<PassengerCarrier> listOfCarriers;
        private static Trip trip;
        private static Selector selector;
        static public PassengerCarrier Select(typeOfTrip typeTrip, pricePrioriti prioritiP, timePrioriti timeP)
        {
            selector = new Selector();
            trip = new Trip() { TypeTrip = typeTrip, PrioritiOfPrice = prioritiP, TimeP = timeP };
            listOfCarriers = CarrierMethods.GetCarrier(trip);
            selector.TheQuickliest(trip, listOfCarriers);
            selector.TheCheapest(trip, listOfCarriers);
            selector.TheMostComfortable(listOfCarriers);
            return listOfCarriers.Count != 0 ? listOfCarriers[0] : null;
        }
    }
}
