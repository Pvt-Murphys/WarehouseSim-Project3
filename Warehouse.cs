///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley Owen, owenrm1@etsu.edu, Josh 
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description:  Contains all components of the simulation.
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
    /// Simulation for all of the loading and unloading trucks
    /// </summary>
    public class Warehouse
    {
        public List<Dock> Docks { get; set; }
        public Queue<Truck> Entrance { get; }

        public Warehouse()
        {
            Docks = new List<Dock>();
            Entrance = new Queue<Truck>();
        }


        public void Run()
        {
            string crateLogFilePath = "crate_log.csv"; //used to send the user to the created file
            int totalTrucksProcessed = 0; // The total number of trucks that were processed during the simulation.
            int totalCratesUnloaded = 0; // The total number of crates that were unloaded during the simulation.
            double totalValueUnloaded = 0; // The total value of the crates that were unloaded during the simulation.
            int totalDocksInUseTime = 0; // The total amount of time that a dock was in use.
            int totalDocksNotInUseTime = 0; // The total amount of time that a dock was not in use.
            int totalDockCost = 0; // The total cost of operating each dock.
            int longestLine = 0; //The longest line at any loading dock during the simulation.
            int totalRevenue = 0; //Total revenue of the warehouse  (total value of crates – total operating cost)

            foreach (Dock dock in Docks)
            {
                Truck currentTruck = dock.SendOff();
                if (currentTruck != null)
                {
                    totalTrucksProcessed++;
                    int dockUseTime = ProcessTruckAtDock(currentTruck, dock);
                    totalDocksInUseTime += dockUseTime;
                    totalDocksNotInUseTime += 1; // Dock is not in use during this time increment
                    totalDockCost += totalDocksInUseTime * 100;
                    UpdateLongestLine(longestLine, dock);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="truck"></param>
        /// <param name="dock"></param>
        /// <returns></returns>
        public int ProcessTruckAtDock(Truck truck, Dock dock)
        {
            int dockUseTime = 0;
            return dockUseTime;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="longestLine"></param>
        /// <param name="dock"></param>
        public void UpdateLongestLine(int longestLine, Dock dock)
        {
            //updates the longest line of a loading dock if that were to change.
        }

    }
}
