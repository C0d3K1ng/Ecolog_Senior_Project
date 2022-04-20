using System;
using System.Windows.Forms;

namespace Ecolog
{
    public partial class EcoJourney : Form
    {
        String username = "Testuser";
        String password;
        String email = "Testmail@test.local";
        String firstName = "Test";
        String lastName = "User";
        String zipCode = "00000";
        String total = "100.00";
        String entries = "52";
        String currentLog = "2.08";
        String avgPrint = "1.92";
        String offset = "0.16";
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
            currentFootprintResult.Text = currentLog;
            differenceResult.Text = offset;

        }
        //Goes to Ecojournal page
        private void ecoJournalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EcoJournal toJournal = new EcoJournal();
            toJournal.ShowDialog();
            this.Close();
        }
        // Goes to Login Screen
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ecologin toLogin = new Ecologin();
            toLogin.ShowDialog();
            this.Close();
        }
    }
}
