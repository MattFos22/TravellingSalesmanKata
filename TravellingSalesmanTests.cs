using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TravellingSalesman
{
    [TestClass]
    public class TravellingSalesmanTests
    {
        [TestMethod]
        public void GivenMaastrichtToMaastricht_ThenDistanceShouldBeZero()
        {
            var locations = new Dictionary<Route, int>();
            locations.Add(new Route("Maastricht", "Maastricht"), 0);

            var calculator = new DistanceCalculator(locations);

            Assert.AreEqual(0,calculator.CalculateShortestDistance());
        }
    }

    public class DistanceCalculator
    {
        private readonly Dictionary<Route, int> _routes;


        public DistanceCalculator(Dictionary<Route, int> routes)
        {
            _routes = routes;
        }

        public int CalculateShortestDistance()
        {
            return _routes.FirstOrDefault().Value;
        }
    }

    public class Route
    {
        public Route(string start, string end)
        {
            Start = start;
            End = end;
        }

        public string Start { get; set; }
        public string End { get; set; }
    }
}
