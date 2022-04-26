using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;
namespace Ecolog
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
                EcoJourney toJourney = new EcoJourney();
                toJourney.ShowDialog(); // Show Ecojourney Page
                                        //this.Close();
                Console.WriteLine("Login Successful");
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
            this.Hide();
            EcoRegister toRegister = new EcoRegister();
            toRegister.ShowDialog();
            this.Close();
        }

        private void forgotBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot toFogot = new Forgot();
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
