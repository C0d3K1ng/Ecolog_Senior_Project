using System;
using System.Windows.Forms;

namespace Ecolog.Forms
{
    public partial class UpdateAccount : Form
    {
        //Instance variables
        bool valUpdate = true;
        // Update text String
        string usernameUP, passwordUP, confirmUP, emailUP,
            fnameUP, lnameUP, zipUP;

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Clear Textfields or set to default
            usernameTB.Text = usernameUP;
            passwordTB.Text = "";
            confirmTB.Text = "";
            emailTB.Text = "";
            fnameTB.Text = "";
            lnameTB.Text = "";
            zipTB.Text = "";
        }
        private void CurrentValues()
        {
            //Get from the Database
        }

        public UpdateAccount()
        {
            InitializeComponent();
        }
        // Goes back to Ecojourney page
        private bool ValidateUpdate()
        {

            return valUpdate;
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide form

            // this will solve the crashing issue
            EcoJourney toJourney = new EcoJourney();
            if (toJourney.IsDisposed == false)
                toJourney.ShowDialog();
            this.Close();
        }
    }
}
