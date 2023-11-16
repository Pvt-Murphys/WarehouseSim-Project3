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
    public class Dock
    {
        public string Id { get; set; }
        public Queue<Truck> Line { get; }
        public double TotalSales { get; set; }
        public int TotalCrates { get; set; }
        public int TotalTrucks { get; set; }
        public int TimeInUse { get; set; }
        public int TimeNotInUse { get; set; }

        public Dock(string id)
        {
            Id = id;
            Line = new Queue<Truck>();
            TotalSales = 0;
            TotalCrates = 0;
            TimeInUse = 0;
            TimeNotInUse = 0;
        }

        /// <summary>
        /// Used in the simulation to join the line to unload at the dock.
        /// </summary>
        /// <param name="truck"></param>
        public void JoinLine(Truck truck)
        {
            Line.Enqueue(truck);
        }

        /// <summary>
        /// Attempts to unload one crate from the first truck in the queue, adding to relevant statistics depending on outcome.
        /// </summary>
        public void UnloadCrate()
        {
            //Checks to see if the line contains any trucks to unload. If not, then marks the time as unused and returns.
            if (Line.Count() == 0)
            {
                TimeNotInUse++;
                return;
            }

            //Catches a potential error in which a truck does not have any crates in it.
            if (Line.Peek().Trailer.Count == 0)
            {
                this.SendOff();
            }
            //unloads the crate, adding its value to the dock's recorded statistic and incrementing other statistics.
            TotalSales += Line.Peek().Trailer.Pop().GetPrice();
            TotalCrates++;
            TimeInUse++;

            //dispatches empty trucks from the dock.
            if (Line.Peek().Trailer.Count == 0)
            {
                this.SendOff();
            }
        }

        /// <summary>
        /// Used in the simulation when the trucks leave the dock.
        /// </summary>
        /// <returns></returns>
        public Truck SendOff()
        {
            if (Line.Count > 0)
            {
                TotalTrucks++;
                return Line.Dequeue();
            }
            else
            {
                return null; // Line is empty
            }
        }
    }
}
