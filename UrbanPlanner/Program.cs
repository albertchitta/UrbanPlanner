using System;
using UrbanPlanner.Models;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate - use the 'new' keyword to create an instance of an object
            //initialize - give an instance an initial value
            Building oneTwoThree = new Building("123 Main Street");
            oneTwoThree.Width = 5;
            oneTwoThree.Stories = 2;
            oneTwoThree.Depth = 10;

            Building fourFiveSix = new Building("456 Main Street")
            {
                Width = 7,
                Depth = 4,
                Stories = 3,
            };

            Building differentOne = new("1023 Something Avenue")
            {
                Width = 6,
                Depth = 15,
                Stories = 1,
            };

            Building sherlocksPlace = new Building("221B Baker Street")
            {
                Width = 10,
                Depth = 10,
                Stories = 10,
            };

            oneTwoThree.Construct();
            fourFiveSix.Construct();
            differentOne.Construct();
            sherlocksPlace.Construct();

            oneTwoThree.Purchase("Scrooge McDuck");
            oneTwoThree.PrintToConsole();
        }
    }
}
