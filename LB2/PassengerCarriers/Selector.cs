using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    internal class Selector
    {
        internal Selector() { }
        internal List<PassengerCarrier> TheQuickliest(Trip trip, List<PassengerCarrier> listOfCarriers)
        {
            Dictionary<PassengerCarrier, int> carriersDictionary = new Dictionary<PassengerCarrier, int>(listOfCarriers.Count);
            int index = 0;
            switch (trip.TimeP)
            {
                case timePrioriti.slowly: index = -1; break;
                case timePrioriti.normally: index = 0; break;
                case timePrioriti.quickly: index = 1; break;
            }
            foreach (PassengerCarrier carrier in listOfCarriers)
            {
                switch (carrier.TimePrioriti)
                {
                    case timePrioriti.slowly: carriersDictionary.Add(carrier, -1); break;
                    case timePrioriti.normally: carriersDictionary.Add(carrier, 0); break;
                    case timePrioriti.quickly: carriersDictionary.Add(carrier, 1); break;
                }
            }
            foreach (var carrier in carriersDictionary)
            {
                if (carrier.Value < index)
                {
                    listOfCarriers.Remove(carrier.Key);
                }
            }
            carriersDictionary.Clear();
            return listOfCarriers;
        }
        internal List<PassengerCarrier> TheCheapest(Trip trip, List<PassengerCarrier> listOfCarriers)
        {
            Dictionary<PassengerCarrier, int> carriersDictionary = new Dictionary<PassengerCarrier, int>(listOfCarriers.Count);
            int index = 0;
            switch (trip.PrioritiOfPrice)
            {
                case pricePrioriti.low: index = -1; break;
                case pricePrioriti.middle: index = 0; break;
                case pricePrioriti.high: index = 1; break;
            }
            foreach (PassengerCarrier carrier in listOfCarriers)
            {
                switch (carrier.PricePrioriti)
                {
                    case pricePrioriti.low: carriersDictionary.Add(carrier, -1); break;
                    case pricePrioriti.middle: carriersDictionary.Add(carrier, 0); break;
                    case pricePrioriti.high: carriersDictionary.Add(carrier, 1); break;
                }
            }
            foreach (var carrier in carriersDictionary)
            {
                if (carrier.Value > index)
                {
                    listOfCarriers.Remove(carrier.Key);
                }
            }
            carriersDictionary.Clear();
            return listOfCarriers;
        }
        internal List<PassengerCarrier> TheMostComfortable(List<PassengerCarrier> listOfCarriers)
        {
            Dictionary<PassengerCarrier, int> carriersDictionary = new Dictionary<PassengerCarrier, int>(listOfCarriers.Count);
            int maxIndex = -1;
            foreach (PassengerCarrier carrier in listOfCarriers)
            {
                switch (carrier.ComfortLevel)
                {
                    case comfortLevel.low: carriersDictionary.Add(carrier, -1); break;
                    case comfortLevel.middle: carriersDictionary.Add(carrier, 0); break;
                    case comfortLevel.high: carriersDictionary.Add(carrier, 1); break;
                }
            }
            foreach (var carrier in carriersDictionary)
            {
                if (carrier.Value > maxIndex)
                {
                    maxIndex = carrier.Value;
                }
            }
            foreach (var carrier in carriersDictionary)
            {
                if (carrier.Value < maxIndex)
                {
                    listOfCarriers.Remove(carrier.Key);
                }
            }
            carriersDictionary.Clear();
            return listOfCarriers;
        }
    }
}
