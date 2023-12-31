﻿///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley O, owenrm1@etsu.edu, Josh, xxxx@xxx.xxx, Daniel L, lynchda@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description: Runs the simulation code and formats the results to be able to be outputed.
//
///////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.SqlServer.Server;
using System.Security.Cryptography.X509Certificates;
using WindowsFormsApp1;
using System.IO;
using System.Windows.Forms;

namespace Project3
{
    public class Warehouse
    {

        //filepath info for keeping count of simulations
        string countPath = Path.GetFullPath("Coconut.txt");
        private int simCount;


        //basic statistics for use in report
        public string finalData = string.Empty;
        public int docksOpen = 20;
        public int longestLine = 0;

        //totalTrucks increases once a truck has been processed.
        public int totalTrucks = 0;
        public int totalCrates = 0;
        public int nextDock = 0;
        public int nextDockID = 1;

        Queue<Truck> entrance;
        Dock[] docks;
        public string crateStatus;

        //Value related variables for use in report
        public double totalValue = 0;
        public double averageCrateVal = 0;
        public double averageTruckVal = 0;
        public double totalCost = 0;
        public double totalRevenue = 0;

        Random rand = new Random();

        /// <summary>
        /// Creates a new Warehouse object with a number of dock objects equal to dockNum
        /// </summary>
        /// <param name="dockNum">Number of docks for the Warehouse to have.</param>
        public Warehouse(int dockNum)
        {
            docks = new Dock[dockNum];
            for (int d = 0; d < dockNum; d++)
            {
                docks[d] = new Dock(nextDockID.ToString());
                nextDockID++;
            }
            simCount = 1;
        }

        /// <summary>`
        ///  Output a report to the user with the results of the simulation in a text file.
        /// </summary>
        /// <param name="args"></param>
        public string Run(Form2 form)
        {
            //This section attempts to read the number of simulations that have been run in total across program executions to create unique .csv files for each simulation run.
            try
            {
                using (StreamReader readCount = new StreamReader(countPath))
                {
                    simCount = Convert.ToInt32(readCount.ReadLine());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Simulation count file could not be read.");
                Console.WriteLine(e.Message);
            }

            try
            {
                using (StreamWriter writeCount = new StreamWriter(countPath))
                {
                    writeCount.WriteLine(simCount + 1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not write simulation count to file.");
                Console.WriteLine(e.Message);
            }
            

            //creates new queue of trucks to arrive at the gate.
            entrance = new Queue<Truck>();


            //BEGIN SIMULATION
            for (int i = 0; i < 48; i++)
            {

                //trucks bound for that interval arrive at gate
                //while (schedule.Peek().GetArrivalInterval() == i)
                //{
                //    entrance.Enqueue(schedule.Dequeue().GetTruck());
                //}
                Random rand = new Random();
                if (i < 12)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (rand.Next(1, 2) == 1)
                        {
                            entrance.Enqueue(new Truck());
                        }
                    }
                } else if (i >= 12 && i < 18)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (rand.Next(1, 2) == 1)
                        {
                            entrance.Enqueue(new Truck());
                        }
                    }
                } else if (i >= 18 && i < 30)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (rand.Next(1, 2) == 1)
                        {
                            entrance.Enqueue(new Truck());
                        }
                    }
                } else if (i >= 30 && i < 36)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (rand.Next(1, 3) == 1)
                        {
                            entrance.Enqueue(new Truck());
                        }
                    }
                } else if (i >= 36)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (rand.Next(1, 2) == 1)
                        {
                            entrance.Enqueue(new Truck());
                        }
                    }
                }

                //trucks at gate are sent to docks, in order of dock that has gone longest without receiving a truck
                while (entrance.Count > 0)
                {
                    //sends truck to next dock, loops next dock if it is at end of indexes
                    if (nextDock < docks.Count() - 1)
                    {
                        docks[nextDock].JoinLine(entrance.Dequeue());
                        //checks if the line at nextDock is longer than longestLine. If it is, makes that line the longest
                        if (docks[nextDock].Line.Count() > longestLine)
                        {
                            longestLine = docks[nextDock].Line.Count();
                        }
                        nextDock++;
                    }
                    else
                    {
                        docks[nextDock].JoinLine(entrance.Dequeue());
                        //checks if the line at nextDock is longer than longestLine. If it is, makes that line the longest

                        if (docks[nextDock].Line.Count() > longestLine)
                        {
                            longestLine = docks[nextDock].Line.Count();
                        }
                        nextDock = 0;
                    }
                }

                totalTrucks = 0;
                totalCrates = 0;
                totalValue = 0;
                //each dock unloads 1 crate, swapping out trucks if truck is empty
                foreach (Dock d in docks)
                {
                    //prepares to write an entry into the report CSV file containing information about the crate, truck, and circumstances.

                    crateStatus = string.Empty;
                    if (d.Line.Count() > 0 && d.Line.Peek().Trailer.Count() > 0)
                    {

                        if (d.Line.Peek().Trailer.Count() > 1)
                        {
                            crateStatus = "The truck still has more crates to unload.";
                            //Unloads the crate at the same time as it writes to the report.
                            RecordCrate(d.UnloadCrate(i), d.Line.Peek(), crateStatus, simCount);
                        }

                        if (d.Line.Peek().Trailer.Count() == 1 && d.Line.Count() > 1)
                        {
                            crateStatus = "The truck has no more crates to unload, and another truck is waiting to take its place.";
                            //Unloads the crate at the same time as it writes to the report, also sends off the empty truck.
                            RecordCrate(d.UnloadCrate(i), d.SendOff(), crateStatus, simCount);
                        }

                        if (d.Line.Peek().Trailer.Count() == 1 && d.Line.Count() == 1)
                        {
                            crateStatus = "The truck has no more crates to unload, and no other trucks are in the line.";
                            //Unloads the crate at the same time as it writes to the report, also sends off the empty truck.
                            RecordCrate(d.UnloadCrate(i), d.SendOff(), crateStatus, simCount);
                        }


                        //This is an example code of the method to write the crate to the csv file, note that the two method calls MUST occur, as otherwise the crate will not be unloaded nor the truck sent off it is empty.
                        //RecordCrate(d.UnloadCrate(i), d.Sendoff/d.Line().Peek(), crateStatus);
                        if (d.Line.Count() == 0)
                        {
                            d.TimeNotInUse++;
                        }

                    }


                }

                //updates totals each time interval
                //resets totals stored in dock objects to prevent exponential growth
                totalTrucks = 0;
                totalCrates = 0;
                totalValue = 0;
                //loops through docks to add their totals to the relevant totals
                foreach (Dock d in docks)
                {

                    //adds up the total values as the simulation runs, for dynamic display.

                    totalTrucks += d.TotalTrucks;
                    totalCrates += d.TotalCrates;
                    totalValue += d.TotalSales;
                }
                //calculates other statistics for display in program.
                totalCost = totalCost + docksOpen * 100;
                averageCrateVal = totalValue / totalCrates;
                averageTruckVal = totalValue / totalTrucks;
                totalRevenue = totalValue - totalCost;


                form.AddDataRow(totalCrates.ToString(), totalValue.ToString(), totalCost.ToString(), totalRevenue.ToString(), averageCrateVal.ToString(), averageTruckVal.ToString(), longestLine.ToString());
            }



            // end scenario statistics such as computed averages, as well a console line to display them

            // adds a new data row to the data table
            form.AddDataRow(totalCrates.ToString(), totalValue.ToString(), totalCost.ToString(), totalRevenue.ToString(), averageCrateVal.ToString(), averageTruckVal.ToString(), longestLine.ToString());
            return finalData = ($"{totalTrucks} trucks, {totalCrates} crates. {totalValue} earned from crates, {totalCost} in operating costs, {totalRevenue} overall revenue. {averageCrateVal} is average value per crate.");
        }

        /// <summary>
        /// Used in the simulation to display crate information to a csv file.
        /// </summary>
        /// <param name="crate"></param>
        /// <param name="truck"></param>
        /// <param name="crateStatus"></param>
        public static void RecordCrate(Crate crate, Truck truck, string crateStatus, int simCount)
        {
            string filePath = $"simulationresults_{simCount}.csv";

            // Use using statement to ensure the FileStream and StreamWriter are properly closed and disposed
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                // Check if the CSV file is empty, if so add the header
                if (fs.Length == 0)
                {
                    string header = "Time Increment,Truck Driver Name,Delivery Company Name,Crate ID,Crate Value,Scenario";
                    sw.WriteLine(header);
                }

                    // Append data to the CSV file
                    string data = $"{crate.timeInterval},{truck.Driver},{truck.DeliveryCompany},{crate.Id},{crate.Price},{crateStatus}";
                    sw.WriteLine(data);
            }
        }

    }
}