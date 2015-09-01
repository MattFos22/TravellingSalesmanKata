using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TravellingSalesman
{
    [TestClass]
    public class TravellingSalesmanTests
    {
        private static readonly Dictionary<Route, int> Locations = new Dictionary<Route, int>()
        {
            {new Route("New York", "New York"), 0 },
            {new Route("New York", "Dublin"), 70 },
            {new Route("Dublin", "London"), 10 },
            {new Route("New York", "Amsterdam"), 100 },
            {new Route("Amsterdam", "London"), 20 }
        };

        [TestInitialize]
        public void Setup()
        {
            
        }



        [TestMethod]
        public void GivenNYtoNY_ThenDistanceShouldBeZero()
        {
            var calculator = new DistanceCalculator(Locations);
            Assert.AreEqual(0,calculator.CalculateShortestDistance(new Route("New York", "New York")));
        }

        [TestMethod]
        public void GivenNYtoDublin_ThenDistanceShouldBe70()
        {
            var calculator = new DistanceCalculator(Locations);
            Assert.AreEqual(70, calculator.CalculateShortestDistance(new Route("New York", "Dublin")));
        }

        [TestMethod]
        public void GivenDublinToNY_ThenDistanceShouldBe70()
        {
            var calculator = new DistanceCalculator(Locations);
            Assert.AreEqual(70, calculator.CalculateShortestDistance(new Route("Dublin", "New York")));
        }

        [TestMethod]
        public void GivenNYToLondon_ThenTotalRouteCostShouldBe80()
        {
            var calculator = new DistanceCalculator(Locations);
            Assert.AreEqual(80,calculator.CalculateShortestDistance(new Route("New York", "London")));
            Assert.AreEqual(80, calculator.CalculateShortestDistance("New York", "London"));

        }

    }

}
