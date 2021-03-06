﻿using NUnit.Framework;
using System;
using System.Collections;
using System.Threading;
using Shippo;

namespace ShippoTesting {
    [TestFixture ()]
    public class RateTest : ShippoTest {

        [Test ()]
        public void TestValidCreate ()
        {
            ShippoCollection<Rate> testObject = RateTest.getDefaultObject ();
            Assert.IsNotNull (testObject.Data);
        }

        public static ShippoCollection<Rate> getDefaultObject ()
        {
            Shipment testObject = ShipmentTest.getDefaultObject ();
            Hashtable parameters = new Hashtable ();
            parameters.Add ("id", testObject.ObjectId);
            parameters.Add ("currency_code", "USD");

            // Use Synchronized rates method
            return getAPIResource ().GetShippingRatesSync (parameters);
        }
    }
}

