/*
    Project: Ecolog
    Filename: Footprint.cs
    Author: Evan Kern
    Purpose: To hold Footprint data
 
 
 */
namespace Ecolog
{
    /**
        Class represents A user's footprint statistics 
        from database.
     */
    public class Footprint
    {
        //User id 
        public int userid { get; set; }
        //Total footprint
        public double total { get; set; }
        /**
           represents amount of entries
         */
        public int entries { get; set; }
        /**
            Gets and sets Average from 
            footprints in database
         */
        public double average { get; set; }
        /**
           Sets and Gets the Offseted
            Carbon Footprint 
         */
        public double offset { get; set; }
    }
}
