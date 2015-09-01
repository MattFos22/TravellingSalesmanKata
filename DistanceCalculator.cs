using System;
using System.Collections.Generic;
using System.Linq;

namespace TravellingSalesman
{
    public class DistanceCalculator
    {
        private readonly Dictionary<Route, int> _routes;

        public DistanceCalculator(Dictionary<Route, int> routes)
        {
            _routes = routes;
        }

        public int CalculateShortestDistance(Route route)
        {
            return _routes.FirstOrDefault(x => x.Key.Equals(route)).Value;
        }

        public int CalculateShortestDistance(string start, string end)
        {
            int totalCost = 0;

            var startingLocation = _routes.FirstOrDefault(x => x.Key.Start == start && x.Key.End != start);

            return totalCost;
        }
    }
}