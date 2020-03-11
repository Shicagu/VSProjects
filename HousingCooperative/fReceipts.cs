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
    public partial class fReceipts : Form
    {
        public fReceipts()
        {
            InitializeComponent();
        }

        HousingCooperativeEntities context = new HousingCooperativeEntities();
        private void LoadData()
        {
            dgvData.DataSource = context.SelectReceipts(null).ToList();
        }
        private void fReceipts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
