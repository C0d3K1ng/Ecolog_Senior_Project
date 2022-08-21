using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ecolog.Forms
{
    public partial class Ecologin : Form
    {
        //Creates two list for getting username and password from database
        List<User> userLogin = new List<User>();
        List<User> passwordLogin = new List<User>();
        String typedUN; // Typed Username
        String typedPW; // Typed Password
        bool valLogin = true;
        public Ecologin()
        {
            InitializeComponent();
            InitializedMyControl();
        }
        //Exit application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {


            if (ValidateForm())
            {
                //Connect to the database
                //DataAccess logAcess = new DataAccess();
                //Takes user name and injects into the database to perform query
                //userLogin = logAcess.GetUsers(usernameTB.Text);
                this.Hide(); // hide form
                Console.WriteLine("Login Successful");

                // this will solve the crashing issue
                EcoJourney toJourney = new EcoJourney();
                if (toJourney.IsDisposed == false)
                    toJourney.ShowDialog();
                this.Close();
            }

        }
        public bool ValidateForm()
        {
            valLogin = true;
            //Get Username and password
            typedUN = usernameTB.Text;
            typedPW = passwordTB.Text;

            //Username can't ben empty
            if (usernameTB.Text == "")
            {
                msgLbl.Text = "Username can't be blank.";
                valLogin = false;

            }
            // Password can't be empty
            if (passwordTB.Text == "")
            {
                msgLbl.Text = "Password can't be blank.";
                valLogin = false;
            }
            return valLogin;
        }
        private void InitializedMyControl()
        {
            //Clears fields set characters to blank
            passwordTB.Text = "";
            passwordTB.PasswordChar = '*';
            valLogin = true;
            msgLbl.Text = "";

        }
        public Boolean userFound(String username, String password)
        {
            Boolean access = false;

            return access; //
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide form

            // this will solve the crashing issue
            EcoRegister toRegister = new EcoRegister();
            if (toRegister.IsDisposed == false)
                toRegister.ShowDialog();
            this.Close();
        }

        private void forgotBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide form

            // this will solve the crashing issue
            Forgot toFogot = new Forgot();
            if (toFogot.IsDisposed == false)
                toFogot.ShowDialog();
            this.Close();
        }
        private void passwordTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                // Enter Key press
                //Do as above
            }
        }
    }
}
