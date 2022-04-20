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
    public partial class EcoRegister : Form
    {
        /*
            instance variables for registration
        INSERT dbo.Users (UserID, Username, Password, Email, First_Name, Last_Name, Zip)
	    VALUES (1, 'TestUser', 'TestPassword123', 'testMail@test.local', 'Test', 'User', '1111')
            GO
         */
        String usernameReg; // Username
        String passwordReg; // Password
        String emailReg; // Email 
        String confirmReg; //  Confirm password
        String fnameReg; // First Name
        String lnameReg; // Last Name
        String zipReg; // Zip code
        
        //Regular Expressions

        String usernameRX = @"/[a-zA-Z][a-zA-Z0-9-_]{3,32}/gi"; 
        String passwordRX = @"/^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$/gm";
        String emailRX = @"/[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/g";
        String nameRX = @"/^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$/";
        String zipRX = @"/\\d{5}$/"; // Zipcode 5 digits
        public EcoRegister()
        {
            InitializeComponent();
        }

        /**
            Takes all textfields and assign them values
            Then sends information to the database
            
         */
        private void registerBtn_Click(object sender, EventArgs e)
        {
            //Validators for registeration
            Boolean valUser = false, valPass = false, valEmail = false, valNames = false, valZip = false;

            //Set the variables
            usernameReg = usernameTB.Text; // Username 
            passwordReg = passwordTB.Text; // Password
            confirmReg = confirmTB.Text; // Confirm Password
            emailReg = emailTB.Text; // Email
            fnameReg = fnameTB.Text; // First Name
            lnameReg = lnameTB.Text; // Last Name
            zipReg = zipTB.Text; // Zip Code
            // Regular expression variable
            //Creates a regex for the pattern
            Regex userRegEx = new Regex(usernameRX);
            // Uses a match to parse through entry
            Match userMatch = userRegEx.Match(usernameReg); 
            //Username Validation 
            if (usernameReg != "")
            {
                //If the username is valid
                 if (userMatch.Success)
                {
                    //Good Username 
                    valUser = true;
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Clear the textboxes
            usernameTB.Text = "";
            passwordTB.Text = "";
            confirmTB.Text = "";
            emailTB.Text = "";

        }
        //Goes back to Login Page
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ecologin toLogin = new Ecologin();
            toLogin.ShowDialog();
            this.Close();
        }
    }
}
