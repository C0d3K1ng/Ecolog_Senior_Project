using System;
using System.Windows.Forms;

namespace Ecolog
{
    public partial class EcoJourney : Form
    {
        //Default Values
        String username = "ZFarooqi";
        String password = "********";
        String email = "ZFarooqi@uakron.edu";
        String firstName = "Zarreen";
        String lastName = "Farooqi";
        String zipCode = "44325";
        String total = "0.0";
        String entries = "0";
        String currentLog = "0.0";
        String avgPrint = "0.0";
        String offset = "0.0";
        public EcoJourney()
        {
            InitializeComponent();
            //Set test values
            userResult.Text = username;
            emailResult.Text = email;
            firstNameResult.Text = firstName;
            lastNameResult.Text = lastName;
            totalResult.Text = total;
            averageResult.Text = avgPrint;
            lastLogRslt.Text = currentLog;
            differenceResult.Text = offset;

        }
        //Goes to Ecojournal page
        private void ecoJournalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EcoJournal toJournal = new EcoJournal();
            toJournal.ShowDialog();
            
        }
        // Goes to Login Screen
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ecologin toLogin = new Ecologin();
            toLogin.ShowDialog();
            this.Close();
        }

        private void ecoSpherebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EcoSphere toSphere = new EcoSphere();
            toSphere.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Goes to update page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateAccountbtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            UpdateAccount toUpdate = new UpdateAccount();
            toUpdate.ShowDialog();
            //this.Close();
        }
    }
}
