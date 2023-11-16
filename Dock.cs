///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley Owen, owenrm1@etsu.edu, Josh 
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description: Defines the dock and how it is used in the simulation.
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
        /// <param name="i">interval the crate was unloaded in</param>
        /// <returns></returns>
        public Crate UnloadCrate(int i)
        {
            //Checks to see if the line contains any trucks to unload. If not, then marks the time as unused and returns.
            if (Line.Count() == 0)
            {
                TimeNotInUse++;
                return null;
            }

            //Catches a potential error in which a truck does not have any crates in it.
            if (Line.Peek().Trailer.Count == 0)
            {
                this.SendOff();
            }
            //unloads the crate, adding its value to the dock's recorded statistic and incrementing other statistics.
            Line.Peek().Trailer.Peek().SetUnloadTime(i);
            TotalSales += Line.Peek().Trailer.Peek().GetPrice();
            TotalCrates++;
            TimeInUse++;
            return Line.Peek().Trailer.Pop();
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
