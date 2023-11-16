///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley O, owenrm1@etsu.edu, Josh, xxxx@xxx.xxx, Daniel L, lynchda@etsu.edu
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
    /// The constructor for the crates that go into the trucks
    /// </summary>
    public class Crate
    {
        string Id; //The crates unique identification number
        double Price; //The cost of the crates contents
        private int timeInterval { get; set; }

        public Crate()
        {
            //Generate a random price from 50$ to 500$
            Random randy = new Random();

            Price = randy.Next(50, 501);
            Id = Guid.NewGuid().ToString(); // Generate a unique ID
            timeInterval = 0;
        }

        /// <summary>
        /// Gets the Price value of the object
        /// </summary>
        /// <returns>the Price value of the Crate object as a double</returns>
        public double GetPrice()
        {
            return Price;
        }

        /// <summary>
        /// Sets the interval during which this crate is unloaded.
        /// </summary>
        /// <param name="timeInt">interval during which this crate was unloaded.</param>
        public void SetUnloadTime(int timeInt)
        {
            this.timeInterval = timeInt;
        }
    }
}
