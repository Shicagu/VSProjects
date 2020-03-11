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
    public partial class fRates : Form
    {
        public fRates()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fAdministrator fAdministrator = new fAdministrator();
            fAdministrator.Show();
            Hide();
        }

        
        private void LoadData()
        {
            HousingCooperativeEntities context = new HousingCooperativeEntities();
            dgvData.DataSource = context.SelectRates(1).ToList();
            btnEdit.Enabled = true;
        }
        private void fRates_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HousingCooperativeEntities context = new HousingCooperativeEntities();
            fRatesAdd add = new fRatesAdd();
            Rates newRate = context.Rates.Find(dgvData.SelectedCells[0].Value);
            add.lbRate.Text = dgvData.SelectedCells[1].Value.ToString();
            add.nudRate.Value = newRate.Rate;
            add.tbUnit.Text = newRate.Unit;
            add.dtMonthYear.Value = new DateTime(newRate.YearBegin, newRate.MonthBegin, 1);
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            AddOld();
            newRate.Rate = add.nudRate.Value;
            newRate.Unit = add.tbUnit.Text;
            newRate.MonthBegin = add.dtMonthYear.Value.Month;
            newRate.YearBegin = add.dtMonthYear.Value.Year;
            context.SaveChanges();
            LoadData();
        }

        private void AddOld ()
        {
            HousingCooperativeEntities context = new HousingCooperativeEntities();
            Rates oldRate=context.Rates.Find(dgvData.SelectedCells[0].Value);
            oldRate.StatusRate = 2;
            context.Rates.Add(oldRate);
            context.SaveChanges();
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            HousingCooperativeEntities context = new HousingCooperativeEntities();
            dgvData.DataSource = context.SelectRates(2).ToList();
            btnEdit.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
