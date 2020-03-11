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
    public partial class fOwnersAdd : Form
    {
        public fOwnersAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbFIO.TextLength > 0 && tbPassport.MaskFull)
                DialogResult = DialogResult.OK;
        }
    }
}
