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
    public partial class EcoJournal : Form
    {
        public EcoJournal()
        {
            InitializeComponent();
        }
        /**
            This is where the math is done
         */
        public double calculations()
        {
            double totalFP = 0.0;


            return totalFP;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EcoJourney toJourney = new EcoJourney();
            toJourney.ShowDialog();
            this.Close();
        }
    }
}
