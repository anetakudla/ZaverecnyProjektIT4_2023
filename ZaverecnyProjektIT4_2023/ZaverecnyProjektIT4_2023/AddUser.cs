using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjektIT4_2023
{
    public partial class AddUser : Form
    {
        SqlRepository sql;
        public AddUser()
        {
            InitializeComponent();
            sql = new SqlRepository();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoPassword.Text != "" && comboBoxRole.Text != "")
            {
                sql.AddUser(textBoxUsername.Text, textBoPassword.Text, comboBoxRole.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vyplňtě všechny okna");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
