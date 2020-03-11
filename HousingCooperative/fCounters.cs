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
    public partial class fCounters : Form
    {
        public fCounters()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fAdministrator fAdministrator = new fAdministrator();
            fAdministrator.Show();
            Hide();
        }

        HousingCooperativeEntities context = new HousingCooperativeEntities();
        private void LoadData()
        {
            dgvData.DataSource = context.SelectCounters().ToList();
        }
        private void fCounters_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fCountersAdd add = new fCountersAdd();
            var typeContersList = from TypesOfCounters in context.TypesOfCounters select TypesOfCounters;
            add.cbTypeCounter.DataSource = typeContersList.ToList();
            add.cbTypeCounter.ValueMember = "IdType";
            add.cbTypeCounter.DisplayMember = "Description";
            add.cbTypeCounter.SelectedIndex = -1;

            var housesList = from Houses in context.Houses select Houses;
            add.cbNumberHouse.DataSource = housesList.ToList();
            add.cbNumberHouse.ValueMember = "IdHouse";
            add.cbNumberHouse.DisplayMember = "NumberHouse";
            add.cbNumberHouse.SelectedIndex = -1;

            DialogResult result = add.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            Counters counter = new Counters();
            counter.TypeCounter = (int)add.cbTypeCounter.SelectedValue;
            counter.House = (int)add.cbNumberHouse.SelectedValue;
            counter.Information = (int)add.nudInformation.Value;
            context.Counters.Add(counter);
            context.SaveChanges();
            MessageBox.Show("Успешное добавление");
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                fCountersAdd add = new fCountersAdd();
                Counters counter = context.Counters.Find(dgvData.SelectedCells[0].Value);
                var typeContersList = from TypesOfCounters in context.TypesOfCounters select TypesOfCounters;
                add.cbTypeCounter.DataSource = typeContersList.ToList();
                add.cbTypeCounter.ValueMember = "IdType";
                add.cbTypeCounter.DisplayMember = "Description";
                add.cbTypeCounter.SelectedValue = counter.TypeCounter;

                var housesList = from Houses in context.Houses select Houses;
                add.cbNumberHouse.DataSource = housesList.ToList();
                add.cbNumberHouse.ValueMember = "IdHouse";
                add.cbNumberHouse.DisplayMember = "NumberHouse";
                add.cbNumberHouse.SelectedIndex = counter.House;

                add.nudInformation.Value = counter.Information;

                DialogResult result = add.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                counter.TypeCounter = (int)add.cbTypeCounter.SelectedValue;
                counter.House = (int)add.cbNumberHouse.SelectedValue;
                counter.Information = (int)add.nudInformation.Value;
                context.SaveChanges();
                MessageBox.Show("Изменения сохранены");
                LoadData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show(this, "Вы уверены, что хотите удалить данные счётчика?", "Подтвердите действия",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                    return;
                Counters counter = context.Counters.Find(dgvData.SelectedCells[0].Value);
                context.Counters.Remove(counter);
                context.SaveChanges();
                MessageBox.Show("Информация о счётчике удалена","Успешно");
                LoadData();
            }
        }
    }
}
