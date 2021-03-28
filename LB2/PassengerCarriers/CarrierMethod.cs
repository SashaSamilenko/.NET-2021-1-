﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    internal static class CarrierMethod
    {
        static internal List<PassengerCarrier> GetCarrier(Trip trip)
        {
            List<PassengerCarrier> listOfCarriers = new List<PassengerCarrier>();
            switch(trip.TypeTrip)
            {
                case typeOfTrip.inCity:
                    listOfCarriers.Add(new Taxi());
                    listOfCarriers.Add(new IntracityBus());
                    break;
                case typeOfTrip.beetwenCities:
                    listOfCarriers.Add(new IntercityTrain());
                    listOfCarriers.Add(new IntrecityBus());
                    break;
                case typeOfTrip.beetwenCountries:
                    listOfCarriers.Add(new IntercountryTrain());
                    listOfCarriers.Add(new IntercountryBus());
                    listOfCarriers.Add(new Plane());
                    break;
                case typeOfTrip.beetwenContinents:
                    listOfCarriers.Add(new Plane());
                    break;
                default: new ArgumentException("This type of carriers cannot find! Please, try your attempt again!"); break;
            }
            return listOfCarriers;
        }
        /*static private PassengerCarrier GetCarrierIncludingPrioriti(typeOfTrip type, pricePrioriti prioriti)
        {

        }*/
    }
}
