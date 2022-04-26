using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecolog
{
    public partial class Forgot : Form
    {
        //Instance variables
        string email, sentCode, codeField, password, confirmPW;
        bool valEmail = true, valPass = true, valCode = true;
        public Forgot()
        {
            InitializeComponent();
        }
        //Go back
        private void backBtn_Click(object sender, EventArgs e)
        {
            Ecologin toLogin = new Ecologin();
            this.Hide();
            toLogin.ShowDialog();
            this.Close();
        }
        // Send the Email Code
        private void sendCodeBtn_Click(object sender, EventArgs e)
        {

        }
        //Validates email
        private bool ValidEmail() 
        {
            
            if (emailTB.Text.Length == 0)
            {
                valEmail = false;
            }
            // send to database
            

            // if in database send email

            return valEmail;
        }
        //Check code
        private bool ValidCode() 
        {
            // From Code Textfield
            codeField = codeTB.Text;

            //Gets back code sent
            return valCode;
        }
        //validate passwords
        private bool ValidPasswords()
        {
            //Set the variables
            password = newPwTB.Text;
            confirmPW = confirmTB.Text; // Password to Textbox
            return valPass;
        }
        // checks the code
        private void codeBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
