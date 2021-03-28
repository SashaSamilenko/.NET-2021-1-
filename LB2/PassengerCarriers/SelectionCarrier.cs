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
        private static double volumeOfBaggage;
        static public List<PassengerCarrier> Select(typeOfTrip typeTrip, pricePrioriti prioritiP,timePrioriti timeP, double lengthBaggage, double weightBaggage, double heightBaggage)
        {
            volumeOfBaggage = lengthBaggage * weightBaggage * heightBaggage;
            trip = new Trip() { TypeTrip = typeTrip, PrioritiOfPrice = prioritiP,TimeP=timeP,VolumeOfBaggage=volumeOfBaggage };
            listOfCarriers=CarrierMethod.GetCarrier(trip);
            //return ChooseCarrier();
            TheQuickliest();
            TheCheapest();
            return listOfCarriers;
        }
        static private PassengerCarrier ChooseCarrier()
        {
            foreach(PassengerCarrier carrier in listOfCarriers)
            {
                if(carrier.TimePrioriti!=trip.TimeP)
                {
                    listOfCarriers.Remove(carrier);
                }
                else 
                {
                    if(trip.TimeP==timePrioriti.quickly)
                    {

                    }
                }
            }
            return listOfCarriers[0];
        }
        static private void TheQuickliest()
        {
            int index=0;
            switch (trip.TimeP)
            {
                case timePrioriti.slowly: index = -1; break;
                case timePrioriti.normally: index = 0; break;
                case timePrioriti.quickly: index = 1; break;
            }
            Dictionary<PassengerCarrier,int> carriersDictionary = new Dictionary<PassengerCarrier, int>(listOfCarriers.Count);
            foreach (PassengerCarrier carrier in listOfCarriers)
            {
                switch (carrier.TimePrioriti)
                {
                    case timePrioriti.slowly: carriersDictionary.Add(carrier, -1); break;
                    case timePrioriti.normally: carriersDictionary.Add(carrier,0); break;
                    case timePrioriti.quickly: carriersDictionary.Add(carrier,1); break;
                }
            }
            foreach (var carrier in carriersDictionary)
            {
                if(carrier.Value<index)
                {
                    //carriersDictionary.Remove(carrier.Key);
                    listOfCarriers.Remove(carrier.Key);
                }
            }
        }
        static private void TheCheapest()
        {
            int index = 0;
            switch (trip.PrioritiOfPrice)
            {
                case pricePrioriti.low: index = -1; break;
                case pricePrioriti.middle: index = 0; break;
                case pricePrioriti.high: index = 1; break;
            }
            Dictionary<PassengerCarrier, int> carriersDictionary = new Dictionary<PassengerCarrier, int>(listOfCarriers.Count);
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
                    //carriersDictionary.Remove(carrier.Key);
                    listOfCarriers.Remove(carrier.Key);
                }
            }
        }
    }
}
