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
            this.Hide();
            EcoJourney toJourney = new EcoJourney();
            toJourney.ShowDialog();
            this.Close(); // Close the form
        }
    }
}
