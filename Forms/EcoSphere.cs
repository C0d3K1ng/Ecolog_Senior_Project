using System;
using System.Windows.Forms;

namespace Ecolog.Forms
{
    public partial class EcoSphere : Form
    {
        public EcoSphere()
        {
            InitializeComponent();
        }

        //Goes back to EcoJournal Page
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide form

            // this will solve the crashing issue
            EcoJourney toJourney = new EcoJourney();
            if (toJourney.IsDisposed == false)
                toJourney.ShowDialog();
            this.Close();
        }

        private void epaLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Environmental Protection Agency
            System.Diagnostics.Process.Start("https://www.epa.gov/");
        }

        private void ipccLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Intergovernmental Panel on Climate Change
            System.Diagnostics.Process.Start("https://www.ipcc.ch/");
        }

        private void projectlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Project Drawdown
            System.Diagnostics.Process.Start("https://www.drawdown.org/");
        }
    }
}
