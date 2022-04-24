using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecolog
{
    /*
       This class is used to calculate the weekly 
        footprint from the Ecojounral.
        Units are in kg/CO2e 
        Sources are from the EPA, IPCC and NOOAA
     */
    /// <summary>
    /// Class for calculation Carbon Footprint
    /// 
    /// </summary>
    class Calculator
    {
        //Instance Variables
        double average = 0.307; // Average weekly footprint of an american

        //Diet
        /*
               Calculate Diet Footprint
               From Daily averages
               Vegan 2336 gCO2e day
               Pesectarian 3700 gCO2e day
               Vegetarain 2596 gCO2e day
               Omnivore 3959 gCO2e day
               Multiply by 7 to get the weekly value
               
               Vegan 16.352 kg per week
               Vegetarian 18.171 kg per week
               Pesectarian 25.900 kgCO2e kg per week
               Meat 27.713 kgCO2e per week
               Units in tCO2e a year
               Divide again by 1000
               Vegan 0.016
               Vegatarian 0.018
               Pesectarian 0.026
               Meat 0.028
               Units kgCO2e per week
            */
        double dietTtl = 0.0; // Diet Total
        double veganFP = 16.35; // Vegan diet footprint 
        double vegtFP = 18.17; // Vegetarian 
        double pescFP = 25.9; // Pesectarian
        double meatFP = 27.71; // Meat

        /* Calculate Travel Footprint
               Footprint is calculated by miles
               Electric Cars have an annual footprint of
               3932 lbs of of CO2 a year
               Need tCO2e per week
               multiply by 0.45
               Gasoline cars have footprint of 11435lbs a year
               Electric to car Ratio 3932/11435
               that leads to 5.189 or 5.2 metric tons of CO2e a year
               0.78 lb per mile or 0.35 kg per mile
               0.0035 per week
               Air Travel has about a 53 per mile
               or 24 kg per mile
               Walking give us 56 CO2e per kilometer
               in miles thats 56 * 0.61 = 34.72 g per mile
               34.72/1000 = 0.03472 gram
        */
        int walkMiles = 0;
        double walkFP = 0.034; // Walk factor
        //double walkTtl = walkMiles * walkFP;
        //Car Emissions

        // Multiply these by car miles
        double gasCarFP = 0.35;// 0.35 kgCO2e per mile
        double elCarFP = 0.12; // 0.12 kgCO2e per mile
                               //Travel total
        double travelFP = 0.0;
        // Values are initialized to zero
        int carMiles = 0;  // miles driven
                           // Bike Calculations
        int bikeMiles = 0;
        double bikeFP = 20.84;
        // double bikeTtl = bikeMiles * bikeFP;
        int planeMiles = 0;
        double planeFP = 0.35;
        //double planeTtl = planeMiles * planeFP;
        //int milesTotal = carMiles + bikeMiles + planeMiles; // Total miles
        double avgTravel = 0.1; // Average emission travel per year

        /* 
         * Calculate Recycling Footprint
            Average CO2e based of 1.5ltr bottle of 
            Glass Bottle 503 g or 0.503 kg per bottle
            Aluminum Cans 401 or .401 kg per can
            Plastic 633g or 0.633 kg per bottle
            2.31 * 10^-2, 0.0231 metric tons CO2e
            or 23 kgs pg waste recycled
            
            now subtract from typical waste
          */
        double wasteFP = 23.1; // 23.1 kg per garbage bag

        // Aluminum, Metal can Calculations
        double canFP = 0.4; // .401 kg CO2e per can
        int cans = 0;
        // double cansTtl = canFP * cans;
        // Glass Calculations
        int glass = 0;
        double glassFP = 0.503; // Glass Bottles
                                //double glassTtl = glassFP * glass;
                                // Plastic Calculations
        int plastic = 0;
        double plasticFP = 0.633; // Plastic bottles
        //double plasticTtl = plastic * plasticFP;
        //  double recFP = wasteFP - (cansTtl + glassTtl + plasticTtl);
        /* Calculate Home Footprint
            By source
            Space heating is 0.42 percent of energy of us homes
            Gas 0.9 lb per kwh
            0.9 * .453 = 0.401
            
            Solar 0.004 kg/ per kwh
            Wind  0.001 kg/ per kwh
            Coal 2.2 lbs Per kwh
            
            2.2lbCO2e * 0.453kg = 1kgCO2e per kwh for coal
            Average Energy price
            13.15 cents/kWh
              
         
         */
        double gasFP = 0.4;
        double coalFP = 1.0;
        double greenFP = 0.0025; // Solar and Wind footprint Neglible
        double perWeek = 0.25;
        double kwh = 0.13; // kilo watt hour, power cost
        double eBill = 0.0; // Energy Electric Bill
        double energyFP = 0.0;
       
        /// <summary>
        /// For vegan Diet
        /// </summary>
        /// <returns> CO2e of vegan diet</returns>
        public double veganImpact()
        {
            return veganFP;
        }
        // Vegatarian
        /// <summary>
        /// Average emission generated by a vegetarian diet
        /// </summary>
        /// <returns> CO2e of weekly vegetarian emissions</returns>
        public double vegetarianImpact()
        {
            return vegtFP;
        }
        // Pesectarain
        /// <summary>
        /// Fish Diet, 
        /// </summary>
        /// <returns>CO2e of a pesectarian diet</returns>
        public double pesectarianImpact()
        {
            return pescFP;
        }
        //Meat
        public double meatImpact()
        {
            return meatFP;
        }


        //Recylcing 
        /// <summary>
        /// Used when no is answered for the recycling question
        /// </summary>
        /// <returns>
        /// Average Footprint of Waste
        /// </returns>        
        public double recylceNo()
        {
            return wasteFP;
        }

        // Get Ecojournal Class 
      
        /// <summary>
        /// Calculates Carbon Footprint of glass bottles
        /// </summary>
        /// <param name="glassBottles"> Amount of glasss bottles</param>
        /// <returns> C02e of glass bottles saved </returns>
        public double glassRecycling(int glassBottles)
        {
            glass = glassBottles;
            double glassTtl = glass * glassFP;
            return glassTtl;
        }
        /// <summary>
        /// Calculates Carbon Footprint of plastic bottles
        /// </summary>
        /// <param name="plasticBottles"> Amount of plastic bottles</param>
        /// <returns> CO2e of plastic bottles</returns>
        public double plasticRecycling(int plasticBottles)
        {
            plastic = plasticBottles;
            double plasticTtl = plastic * plasticFP;
            return plasticTtl;
        }
        /// <summary>
        /// Calculates Carbon footprint of metal bottles
        /// </summary>
        /// <param name="metalCans">Metal cans recycled</param>
        /// <returns>kgC02e sequestered by recycling</returns>
        public double metalRecycling(int metalCans)
        {
            cans = metalCans;
            double metalTtl = cans * canFP;
            return metalTtl;
        }

        //Travel footprint 
        /// <summary>
        /// Calculates the emissions of walking
        /// </summary>
        /// <param name="walkedMiles"> Miles walked</param>
        /// <returns>kgCO2e of miles walked </returns>
        public double walkingEmissions(int walkedMiles)
        {
            //Set the value
            walkMiles = walkedMiles;
            double walkTotal = 0.0;
            walkTotal = walkMiles * walkFP;
            return walkTotal;
        }
        public double bikingEmissions(int bikedMiles)
        {
            //set the values
            bikeMiles = bikedMiles;
            double bikeTotal = bikeMiles * bikeFP;
            return bikeTotal; // return the emissions
        }

        public double flyingEmissions(int flownMiles)
        {
            double planeTotal = flownMiles * planeFP;
            return planeTotal;
        }
     
        public double gasCar(int drivenMiles) 
        {
            carMiles = drivenMiles;
            double carTotal = carMiles * gasCarFP;
            return carTotal;
        }
        public double electricCar(int drivenMiles)
        {
            carMiles = drivenMiles;
            double carTotal = carMiles * elCarFP;
            return carTotal;
        }
        // Home footprint
  
        //Energy Bill and Emissions 
        /// <summary>
        /// Gas Emission Calculation for home values
        /// Uses average kwh rate
        /// </summary>
        /// <param name="lightBill">Light bill in $ amount</param>
        /// <returns>kg/CO2e walking </returns>
        public double gasPowerEmissions(double lightBill) 
        {
            eBill = lightBill;
            double homeTtl = 0.0;
            homeTtl = gasFP * kwh * perWeek * eBill;
            return homeTtl;
        }
        /// <summary>
        /// Coal Emissions for a home based on lightbill
        /// </summary>
        /// <param name="lightBill">$ Amount of lightbill</param>
        /// <returns>kgCO2e for coal home emissions</returns>
        public double coalPowerEmissions(double lightBill) 
        {
            eBill = lightBill;
            double homeTtl;
            homeTtl = coalFP * kwh * perWeek * eBill;
            return homeTtl;
        }
        /// <summary>
        /// Emission Calculations for Green or Solar or Wind energy
        /// </summary>
        /// <param name="lightBill">$amount of last light bill </param>
        /// <returns>CO2e for green energy</returns>
        public double greenPowerEmissions(double lightBill) 
        {
            eBill = lightBill;
            double homeTtl;
            homeTtl = greenFP * kwh * perWeek * eBill;
            return homeTtl;
        }

        
    }
}
