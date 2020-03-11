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
    public partial class fOwnersOfHouses : Form
    {
        public fOwnersOfHouses()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fAdministrator fAdministrator = new fAdministrator();
            fAdministrator.Show();
            Hide();
        }

        private void fOwnersOfHouses_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        HousingCooperativeEntities context = new HousingCooperativeEntities();
        private void LoadData()
        {
            cbSort.SelectedIndex = -1;
            tbFIO.Text = "";
            dgvData.DataSource = context.SelectOwnersOfHouses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fOwnersOfHousesAdd f = new fOwnersOfHousesAdd();
            var ownersList = from Owners in context.Owners select Owners;
            f.cbOwner.DataSource = ownersList.ToList();
            f.cbOwner.ValueMember = "IdOwner";
            f.cbOwner.DisplayMember = "FIO";
            f.cbOwner.SelectedIndex = -1;
            var housesList = from Houses in context.Houses select Houses;
            f.cbHouse.DataSource = housesList.ToList();
            f.cbHouse.ValueMember = "IdHouse";
            f.cbHouse.DisplayMember = "NumberHouse";
            f.cbHouse.SelectedIndex = -1;
            var statusesList = from Statuses in context.Statuses select Statuses;
            f.cbStatus.DataSource = statusesList.ToList();
            f.cbStatus.ValueMember = "IdStatus";
            f.cbStatus.DisplayMember = "Description";
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            OwnersOfHouses ooh = new OwnersOfHouses();
            ooh.Owner = (int)f.cbOwner.SelectedValue;
            ooh.House = (int)f.cbHouse.SelectedValue;
            ooh.DatePayment = f.dtDate.Value.Date;
            ooh.StatusOwner = (int)f.cbStatus.SelectedValue;
            context.OwnersOfHouses.Add(ooh);
            context.SaveChanges();
            MessageBox.Show("Успешное добавление");
            LoadData();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fOwnersOfHousesAdd f = new fOwnersOfHousesAdd();
            OwnersOfHouses ooh = new OwnersOfHouses();
            ooh = context.OwnersOfHouses.Find(dgvData.SelectedCells[0].Value);
            var ownersList = from Owners in context.Owners select Owners;
            f.cbOwner.DataSource = ownersList.ToList();
            f.cbOwner.ValueMember = "IdOwner";
            f.cbOwner.DisplayMember = "FIO";
            f.cbOwner.SelectedValue = ooh.Owner;
            var housesList = from Houses in context.Houses select Houses;
            f.cbHouse.DataSource = housesList.ToList();
            f.cbHouse.ValueMember = "IdHouse";
            f.cbHouse.DisplayMember = "NumberHouse";
            f.cbHouse.SelectedValue = ooh.House;
            var statusesList = from Statuses in context.Statuses select Statuses;
            f.cbStatus.DataSource = statusesList.ToList();
            f.cbStatus.ValueMember = "IdStatus";
            f.cbStatus.DisplayMember = "Description";
            f.cbStatus.SelectedValue = ooh.StatusOwner;
            f.dtDate.Value = ooh.DatePayment;
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            
            ooh.Owner = (int)f.cbOwner.SelectedValue;
            ooh.House = (int)f.cbHouse.SelectedValue;
            ooh.DatePayment = f.dtDate.Value.Date;
            ooh.StatusOwner = (int)f.cbStatus.SelectedValue;
            context.SaveChanges();
            MessageBox.Show("Изменения сохранены");
            LoadData();
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
                dgvData.DataSource = context.OrderByDescriptionOwnersOfHouses().ToList();
            else if (cbSort.SelectedIndex == 1)
                dgvData.DataSource = context.OrderByNumberHouseOwnersOfHouses().ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = context.SearchOwnersOfHouses(tbFIO.Text).ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
