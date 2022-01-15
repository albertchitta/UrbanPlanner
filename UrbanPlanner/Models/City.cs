using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Models
{
    class City
    {
        //constructors
        public City(string name, string mayor)
        {
            Name = name;
            Mayor = mayor;
        }

        //fields
        private int _yearEstablished = DateTime.Now.Year;

        //properties
        public string Name { get; set; }
        public string Mayor { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();

        //methods
        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }

        public void PrintCityToConsole()
        {
            string output = $@"City Name: {Name}
Mayor: {Mayor}
Year Established: {_yearEstablished}

Buildings: ";
            Console.WriteLine(output);
        }
    }
}
