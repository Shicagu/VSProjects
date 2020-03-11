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
    public partial class fOwners : Form
    {
        public fOwners()
        {
            InitializeComponent();
        }

        private void fOwners_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        HousingCooperativeEntities context = new HousingCooperativeEntities();
        private void LoadData()
        {
            dgvData.DataSource = context.SelectOwners().ToList();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fAdministrator administrator = new fAdministrator();
            administrator.Show();
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fOwnersAdd add = new fOwnersAdd();
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            Owners owner = new Owners();
            owner.FIO = add.tbFIO.Text;
            owner.Passport = add.tbPassport.Text;
            context.Owners.Add(owner);
            context.SaveChanges();
            MessageBox.Show("Запись выполнена");
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            Owners owner = context.Owners.Find(dgvData.SelectedCells[0].Value);
            fOwnersAdd add = new fOwnersAdd();
            add.tbFIO.Text = owner.FIO;
            add.tbPassport.Text = owner.Passport;
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.Cancel)
                return;         
            owner.FIO = add.tbFIO.Text;
            owner.Passport = add.tbPassport.Text;
            context.SaveChanges();
            MessageBox.Show("Сохранение выполнено");
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = context.SearchOwners(tbFIO.Text).ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
