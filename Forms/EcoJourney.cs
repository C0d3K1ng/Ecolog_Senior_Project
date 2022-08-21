using System;
using System.Windows.Forms;

namespace Ecolog.Forms
{
    public partial class EcoJourney : Form
    {
        String username;
        String password;
        String email;
        String firstName;
        String lastName;
        String zipCode;
        String total;
        String entries;
        String currentLog;
        String avgPrint;
        String offset;
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
            //toJournal.ShowDialog();
            if (toJournal.IsDisposed == false)
                toJournal.ShowDialog();
            this.Close();

        }
        // Goes to Login Screen
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide form

            // this will solve the crashing issue
            Ecologin toLogin = new Ecologin();
            if (toLogin.IsDisposed == false)
                toLogin.ShowDialog();
            this.Close();
        }

        private void ecoSpherebtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide form

            // this will solve the crashing issue
            EcoSphere toSphere = new EcoSphere();
            if (toSphere.IsDisposed == false)
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
            //this.Enabled = false;

            this.Hide(); // hide form

            // this will solve the crashing issue
            UpdateAccount toUpdate = new UpdateAccount();
            if (toUpdate.IsDisposed == false)
                toUpdate.ShowDialog();
            this.Close();
        }
    }
}
