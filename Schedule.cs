using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Schedule
    {
        public Truck truck { get; set; }
        public int interval { get; set; }

        /// <summary>
        /// Constructs a Schedule object containing a Truck object and an integer representing the simulation interval it will arrive in.
        /// </summary>
        /// <param name="truck">Truck object</param>
        /// <param name="interval">Simulation interval the Truck object will arrive in.</param>
        public Schedule(Truck truck, int interval)
        {
            this.truck = truck;
            this.interval = interval;
        }

        /// <summary>
        /// Gets the Truck object inside the Schedule object.
        /// </summary>
        /// <returns>Truck object inside this Schedule object.</returns>
        public Truck GetTruck()
        {
            return this.truck;
        }

        /// <summary>
        /// Gets the simulation interval the Schedule is storing for the Truck object to arrive in.
        /// </summary>
        /// <returns>Simulation interval inside the Schedule object in which the Truck object will arrive.</returns>
        public int GetArrivalInterval()
        {
            return interval;
        }
    }
}
