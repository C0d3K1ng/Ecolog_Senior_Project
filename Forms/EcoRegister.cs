using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Ecolog.Forms
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

        String unPattern = @"^[a-zA-z][a-zA-z$_]{5,11}";
        String pwPattern = @"^(?=[^\d_].*?\d)\w(\w|[!@#$%]){7,20}";
        String emailPattern = @"(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})";
        String namePattern = @"(^[a-zA-z\-]{1,}$)";
        String zipPattern = @"^\d{5}$"; // Zipcode 5 digits
        public EcoRegister()
        {
            InitializeComponent();
            PasswordInit();
        }

        /**
            Takes all textfields and assign them values
            Then sends information to the database
            
         */
        private void registerBtn_Click(object sender, EventArgs e)
        {
            //Add info to data base
            if (ValidateForm())
            {
                this.Hide(); // hide form

                // this will solve the crashing issue
                EcoJourney toJourney = new EcoJourney();
                if (toJourney.IsDisposed == false)
                    toJourney.ShowDialog();
                this.Close();
            }
            ;
        } // end RegisterBtn event
        /// <summary>
        /// Takes in Registration forms and validates it
        /// </summary>
        /// <returns>If the forms filled out correctly</returns>
        public bool ValidateForm()
        {
            //Validators for registeration
            Boolean valReg = true;
            //Set the variables
            msgLbl.Text = "";
            usernameReg = usernameTB.Text; // Username 
            passwordReg = passwordTB.Text; // Password
            confirmReg = confirmTB.Text; // Confirm Password
            emailReg = emailTB.Text; // Email
            fnameReg = fnameTB.Text; // First Name
            lnameReg = lnameTB.Text; // Last Name
            zipReg = zipTB.Text; // Zip Code
            // Regular expression variable
            //Creates a regex for the pattern
            Regex userRegEx = new Regex(unPattern);
            // Uses a match to parse through entry
            // Not needed?
            //Match userMatch = userRegEx.Match(usernameTB.Text); 

            //Username Validation 

            if (usernameReg == "")
            {
                msgLbl.Text = "Username can't be blank";
                valReg = false;
            }

            if (!(userRegEx.IsMatch(usernameReg)))
            {
                //Bad Username 
                valReg = false;
                msgLbl.Text = "Invalid Username";
            }

            //Password Validation
            Regex pwRegEx = new Regex(pwPattern);
            Match pwMatch = pwRegEx.Match(passwordReg);
            Match confirm = pwRegEx.Match(confirmReg);

            //Checks for empty passwords
            if (passwordReg == "")
            {
                valReg = false;
                // Can't be empty string
                msgLbl.Text = "Passwords can't be blank";
            }
            // Valditing Passwords
            if (!(pwMatch.Success))
            {
                valReg = false;
                // Passwords are invalid
                msgLbl.Text = "ERROR: Passwords contain invalid characters.";
            }

            // Confirmation Password 

            if (passwordReg != confirmReg)
            {
                valReg = false;
                // Passwords don't match
                msgLbl.Text = "Error: Passwords don't match";
            }


            // put in own function 
            //Email Validation
            Regex emailRegEx = new Regex(emailPattern);

            if (emailReg == "")
            {
                msgLbl.Text = "Email can't be blank";
                valReg = false;
            }

            if (!(emailRegEx.IsMatch(emailReg)))
            {
                //Invalid Email address 
                msgLbl.Text = "Email contains invalid characters";
                valReg = false;
            }


            // Name validation
            Regex nameRegEx = new Regex(namePattern);
            if (fnameReg == "" || lnameReg == "")
            {
                // If any names are lef blajk
                msgLbl.Text = "Names can't be empty";
                valReg = false;
            }

            if (!(nameRegEx.IsMatch(fnameReg)) || !(nameRegEx.IsMatch(lnameReg)))
            {
                //If invalid names are submitted
                valReg = false;
            }

            // Zip Code Validation
            Regex zipRegEx = new Regex(zipPattern);
            if (zipReg == "")
            {
                msgLbl.Text = " Zip code can't be empty";
                valReg = false;
            }

            if (!(zipRegEx.IsMatch(zipReg)))
            {
                //Invalid zip code
                valReg = false;
                msgLbl.Text = "Invalid zip code has been entered";
            }
            return valReg;
        }
        private void PasswordInit()
        {

            passwordTB.PasswordChar = '*';
            confirmTB.PasswordChar = '*';
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Clear the textboxes
            usernameTB.Text = "";
            passwordTB.Text = "";
            confirmTB.Text = "";
            emailTB.Text = "";
            fnameTB.Text = "";
            lnameTB.Text = "";
            zipTB.Text = "";
            msgLbl.Text = "";
            //valLbl.Text = "";
        }
        //Goes back to Login Page
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide form

            // this will solve the crashing issue
            Ecologin toLogin = new Ecologin();
            if (toLogin.IsDisposed == false)
                toLogin.ShowDialog();
            this.Close();
        }

        private void EcoRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecoDataDataSet.Users' table. You can move, or remove it, as needed.
            // this.usersTableAdapter.Fill(this.ecoDataDataSet.Users);

        }
    }
}
