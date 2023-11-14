///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley Owen, owenrm1@etsu.edu, Josh 
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description:  
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Constructor for the trucks that bring the crates to the docks
    /// </summary>
    public class Truck
    {
        public string Driver { get; set; }
        public string DeliveryCompany { get; set; }
        public Stack<Crate> Trailer { get; }

        //for random driver name generation
        static Random rand = new Random();
        private RandomName nameGen = new RandomName(rand);

        //for random delivery company generation
        private static String[] companyArray = { "XPO Logistics", "J.B. Hunt Transport", "Knight-Swift Transport", "YRC Worldwide", "Schneider", "Landstar Systems", "Old Dominion", "TFI International", "Hub Group", "Estes Express" };


        /// <summary>
        /// Constructor for the truck.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="deliveryCompany"></param>
        public Truck(string driver, string deliveryCompany)
        {
            Driver = driver;
            DeliveryCompany = deliveryCompany;
            Trailer = new Stack<Crate>();
        }
        /// <summary>
        /// Null constructor for the truck.
        /// </summary>
        public Truck()
        {
            //we equal opportunity up in this bitch- but this generates a random name for the driver, thanks to a class I got off of github
            double r = rand.Next();
            if (r % 2 == 0)
            {
                Driver = nameGen.Generate(Sex.Male);
            }
            else
            {
                Driver = nameGen.Generate(Sex.Female);
            }
            //second verse, same as the first; randomly assigns a delivery company
            DeliveryCompany = companyArray[rand.Next(10)];

            Trailer = new Stack<Crate>();
            for (int i = 0; i < rand.Next(1, 26); i++)
            {
                Trailer.Push(new Crate());
            }
        }

        /// <summary>
        /// ToString override for use in debugging.
        /// </summary>
        /// <returns>String representation of the Truck object.</returns>
        public string ToString()
        {
            return $"{this.Driver}, {this.DeliveryCompany}, {this.Trailer.Count()} crates";
        }
    }
}