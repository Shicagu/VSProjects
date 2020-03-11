using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingCooperative
{
    public partial class fAdministrator : Form
    {
        public fAdministrator()
        {
            InitializeComponent();
        }

        private void btnOwners_Click(object sender, EventArgs e)
        {
            fOwners owners = new fOwners();
            owners.Show();
        }

        private void btnHouses_Click(object sender, EventArgs e)
        {
            fHouses houses = new fHouses();
            houses.Show();
            Hide();
        }

        private void btnOwnersOfHouses_Click(object sender, EventArgs e)
        {
            fOwnersOfHouses fOwnersOfHouses = new fOwnersOfHouses();
            fOwnersOfHouses.Show();
            Hide();
        }

        private void btnCounters_Click(object sender, EventArgs e)
        {
            fCounters fCounters = new fCounters();
            fCounters.Show();
            Hide();
        }

        private void btnRates_Click(object sender, EventArgs e)
        {
            fRates fRates = new fRates();
            fRates.Show();
            Hide();
        }

        private void btnReceipts_Click(object sender, EventArgs e)
        {
            fReceipts fReceipts = new fReceipts();
            fReceipts.Show();
            Hide();
        }
    }
}
