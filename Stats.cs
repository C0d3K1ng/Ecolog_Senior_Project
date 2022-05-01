using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecolog
{
    /// <summary>
    /// Takes data from Footprints class and does calculations
    /// </summary>
    class Stats
    {
        //Instance variables
        // Enforce 2 decimal places
        // Old Values
        double avgA = 0.0, totalA = 0.0, lastLogA = 0.0, offsetA = 0.0;
        // New values B
        double avgB = 0.0, totalB = 0.0, lastLogB = 0.0, offsetB = 0.0;
        //User ID
        int userID = 0; 
        
        int entriesA = 0, entriesB = 0;
        
        //Make methods for queries
        //Make methods for calculations

        public int AddEntry(int oldEntries)
        {
            //Increment entries by
            entriesB = entriesA + 1;
            return entriesB;
        }
        public double NewTotal(double total, double lastLog)
        {
            totalA = total;
            lastLogA = lastLog;
            // Adds the old total and new log for a new total
            totalB = totalA + lastLogA;
            return totalB;
        }
        public double NewAverage(double total, int entries)
        {
            //Get the entries
            totalB = total;
            entriesB = entries;
            //Validate that you can't divide by zero
            if (entriesB > 0) 
            {
                avgB = totalB / entries;
            }
            else 
            {
                throw new Exception("Can't divide by zero");
            }
            
            return avgB;
        }
        public double NewLog(double lastLog) 
        {
            // Get the lastest log
            lastLogB = Math.Round(lastLog,2);
            return lastLogB;
        }
        public double OffsetCal(double average, double lastLog)
        {
            //Take the difference between the last log and average
            //Set the values
            avgA = average;

            lastLogA = lastLog;
            // Subtracts the average from the last log
            offsetB = lastLog - avgA;
            return offsetB;
        }
        //returns a message based of offset
        public string Progress(double offset) 
        {
            string status;
            offsetA = offset;
            //Last log would be greater than average
            if (offsetA >= 0.50)
            {
                status = "CARBON POSITIVE: Better Luck next time.";
            }
            // Last log would be less than average
            else if (offsetA <= -0.50)
            {
                status = "CARBON NEGATIVE: Good Job.";
            }
            else if (offsetA < 0.50 && offsetA > -0.50) 
            {
                status = "CARBON NEUTRAL: Okay";
            }
            else 
            {
                status = "ERROR CALCULATING OFFSET";
            }
            return status;
        }
    }
}
