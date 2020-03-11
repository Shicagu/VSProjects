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
    public partial class fHouses : Form
    {
        public fHouses()
        {
            InitializeComponent();
        }

        private void fHouses_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        HousingCooperativeEntities context = new HousingCooperativeEntities();
        private void LoadData()
        {
            dgvData.DataSource = context.SelectHouses();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fAdministrator administrator = new fAdministrator();
            administrator.Show();
            Hide();
        }
    }
}
