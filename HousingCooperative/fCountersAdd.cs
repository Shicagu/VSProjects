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
    public partial class fCountersAdd : Form
    {
        public fCountersAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbTypeCounter.SelectedIndex >= 0 && cbNumberHouse.SelectedIndex >= 0)
                DialogResult = DialogResult.OK;
            else MessageBox.Show("Введены неполные данные");
        }
    }
}
