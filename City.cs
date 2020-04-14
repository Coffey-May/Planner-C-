using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string CityName { get; set; }
        public string Mayor { get; set; }
        public int DateEstablished { get; set; }
        public List<Building> Buildings = new List<Building>();

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
        public City(string name, string mayor, int dateEstablished)
        {
            CityName = name;
            Mayor = mayor;
            DateEstablished = dateEstablished;
        }

    }
}