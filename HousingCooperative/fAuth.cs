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
    public partial class fAuth : Form
    {
        public fAuth()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            HousingCooperativeEntities context = new HousingCooperativeEntities();
            Users user = context.Users.Find(tbLogin.Text);
            try
            {
                if (user.Password == tbPassword.Text)
                {
                    Properties.Settings.Default.ApplicationRole = user.Role;
                    if (user.Role == "Управляющий домом")
                    {
                        fAdministrator administrator = new fAdministrator();
                        administrator.Show();
                        Hide();
                    }
                    else
                    {
                        fReceipts fReceipts = new fReceipts();
                        fReceipts.Show();
                        Hide();
                    }
                }
                else lbWarning.Show();
            }
            catch(Exception)
            {
                lbWarning.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
