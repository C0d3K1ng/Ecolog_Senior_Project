using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Ecolog
{
    public partial class EcoJournal : Form
    {
        //Instance variables
        double dietFP = 0.0;
        double totalFP = 0.0;
        double recycleFP = 0.0;
        double travelFP = 0.0;
        double homeFP = 0.0;

        public EcoJournal()
        {
            InitializeComponent();
        }
        /**
            This is where the math is done
            Takes input from all forms all then validates
         */
        public double Calculations()
        {
            
            
            Calculator footprint = new Calculator();
            //footprint. = glasstextBox.Text;
            /*
                Diet RadioButtons
                each one determines the
                dietary footprint which
             */
            //diet
           
            if (veganRB.Checked)
            {
                dietFP = footprint.veganImpact();
            }
            if(vegetarianRB.Checked)
            {
                dietFP = footprint.vegetarianImpact();
            }
            if (pesectarianRB.Checked)
            {
                dietFP = footprint.pesectarianImpact();
            }
            if (omnivoreRB.Checked)
            {
                dietFP = footprint.meatImpact();
            }
            //totalFP += dietFP; // Adds diet to total footprint

            //Recycling
            bool validInput = true; // flag for input fields
            //Inter inputs
            int glass = 0, plastic = 0, metal = 0, bikeMiles = 0, walkMiles = 0,
                carMiles = 0, planeMiles = 0;
        
            // Tryparse booleans
            bool glassVal = false, plasticVal = false, metalVal = false, walkVal = false,
                bikeVal = false, carVal = false, planeVal = false, eBillVal = false;
            // CO2e Calculator doubles
            double glassRec = 0.0, plasticRec = 0.0, metalRec = 0.0, walkEM = 0.0, bikeEM = 0.0,
                carEM = 0.0, planeEM = 0.0;
            
            // LightBill
            double lightBill = 0.0;
            // No recylcing option
            double avgWaste = footprint.recylceNo();
            if(recycleNoRB.Checked)
            {
                recycleFP = avgWaste;
               
            }
           
            //Recyling Input
            if (recycleYesRB.Checked)
            {
               

                // Glass Bottles
                if (glasstextBox.Text != "")
                {
                    glassVal = int.TryParse(glasstextBox.Text, out glass);
                    if (glass >= 0)
                    {
                         glassRec = footprint.glassRecycling(glass);
                    }
                    else
                    {
                        msgLbl.Text = "Glass can't be less than 0";
                    }
                }
                // Plastic Bottles
                if (plasticTextBox.TextLength > 0)
                {
                    plasticVal = int.TryParse(plasticTextBox.Text, out plastic);
                    if (plastic >= 0)
                    {
                       plasticRec = footprint.plasticRecycling(plastic);
                    }
                    else
                    {
                        msgLbl.Text = "Plastic can't be less than 0";
                    }
                }
               // Metal Cans
               if (metalTextBox.Text != "")
                {
                    metalVal = int.TryParse(metalTextBox.Text, out metal);
                    if (metal >= 0) 
                    {
                        metalRec = footprint.metalRecycling(metal);
                    }
                    else
                    {
                        msgLbl.Text = "Metal cans can't be less than 0";
                    }
                }
                recycleFP = avgWaste - (glassRec + plasticRec + metalRec);
            } // end Recycling checked

            // Travel input
            walkVal = int.TryParse(walkTextBox.Text, out walkMiles);
            if (walkMiles >= 0)
            {
                walkEM = footprint.walkingEmissions(walkMiles);
            }
            else
            {
                msgLbl.Text = "Miles walked can't be less than 0";
            }

            bikeVal = int.TryParse(biketextBox.Text, out bikeMiles);
            if (bikeMiles >= 0)
            {
                bikeEM = footprint.bikingEmissions(bikeMiles);
            }
            else
            {
                msgLbl.Text = "Miles biked can't be less than 0";
            }

            carVal = int.TryParse(driveTextBox.Text, out carMiles);
            if (carMiles >= 0)
            {
                // Determine type of car
                if(gasCarRB.Checked)
                {
                    carEM = footprint.gasCar(carMiles);
                }
                if(electricRB.Checked)
                {
                    carEM = footprint.electricCar(carMiles);
                }
            }
            else
            {
                msgLbl.Text = "Miles driven can't be less than zero";
            }

            //Plane travel
            planeVal = int.TryParse(planetextBox.Text, out planeMiles);
            {
                if(planeMiles >= 0)
                {
                    planeEM = footprint.flyingEmissions(planeMiles);
                }
                else
                {
                    msgLbl.Text = "Can't fly less than 0 miles";
                }
            }

            travelFP = walkEM + bikeEM + carEM + planeEM;
            // Home radiobuttons
            // run through to check for dollar bill
            //Get rid of Bad characters
            string ebillUnformatted = ebillTextBox.Text;
            // Input Validation
            //Characters to be removed
            char[] remover = { '$', ',', '-' }; //Bad Characters
            string ebillFormatted = ebillUnformatted.Trim(remover);
            
          
            eBillVal = double.TryParse(ebillFormatted, out lightBill);
            if (gasHomeRB.Checked)
            {
                if (ebillFormatted.Length != 0 && lightBill >= 0)
                {
                    
                    homeFP = footprint.gasPowerEmissions(lightBill);
                }
                

            }
            if (coalHomeRB.Checked)
            {
                if(ebillFormatted.Length != 0 && lightBill >= 0)
                {
                    homeFP = footprint.gasPowerEmissions(lightBill);
                }
            }
            if (solarHomeRB.Checked || windHomeRB.Checked)
            {
                if (ebillFormatted.Length != 0 && lightBill >= 0)
                {
                    homeFP = footprint.greenPowerEmissions(lightBill);
                }
            }

            //Get all the Footprints
            totalFP = dietFP + recycleFP + travelFP + homeFP;
            return totalFP;

            

            // Get the input
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EcoJourney toJourney = new EcoJourney();
            toJourney.ShowDialog();
            this.Close();
        }
        /**
            Clears the textfields
         */
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Diet
            veganRB.Select();
            //Recycling
            glasstextBox.Text = "";
            metalTextBox.Text = "";
            plasticTextBox.Text = "";
            recycleNoRB.Select();

            //Transportation
            walkTextBox.Text = "";
            planetextBox.Text = "";
            biketextBox.Text = "";
            driveTextBox.Text = "";
            gasCarRB.Select();
            
            //Home
            ebillTextBox.Text = "";
            gasHomeRB.Select();
            // Total
            totalFP = 0.0;
            testTotal.Text = "";
            msgLbl.Text = "";
        }
        // Calculates total button
        private void enterJournalBtn_Click(object sender, EventArgs e)
        {
            // Shows Total Footprint
            // Send to the database
            // EcoData 
            // Footprint CurrentLog = Footprint.CurrentLog(Calculations());
           testTotal.Text = Calculations().ToString();
        }
        /*
 private void button2_Click object sender, EventArg e)
 {
     GetColor(radioButton1);
     GetColor(radioButton2);
     GetColor(radioButton3);
 }

 private void GetColor(radiobutton rdoButton)
 {
     if (rdoButton.Checked)
 }
*/
    }
}
