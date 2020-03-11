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
    public partial class fRatesAdd : Form
    {
        public fRatesAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nudRate.Value > 0)
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Неполные данные");
        }
    }
}
