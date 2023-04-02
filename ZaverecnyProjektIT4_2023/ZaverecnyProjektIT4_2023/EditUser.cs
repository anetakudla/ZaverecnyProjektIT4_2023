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
    public partial class EditUser : Form
    {
        SqlRepository sql;
        string olduser = "";
        public EditUser(User user)
        {
            InitializeComponent();
            sql = new SqlRepository();

            olduser = user.Username;
            textBoxUsername.Text = user.Username;
            comboBoxRole.Text = user.Role.ToString();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && comboBoxRole.Text != "")
            {
                sql.EditUser(olduser.ToString(),textBoxUsername.Text, comboBoxRole.Text);
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
