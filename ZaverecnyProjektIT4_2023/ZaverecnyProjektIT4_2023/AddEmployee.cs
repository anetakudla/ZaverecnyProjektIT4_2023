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
    public partial class AddEmployee : Form
    {
        SqlRepository sql;
        public AddEmployee()
        {
            InitializeComponent();
            sql = new SqlRepository();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxJob.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxEmail.Text != "" && textBoxPhone.Text != "")
            {
                sql.AddEmployee(textBoxJob.Text, textBoxFirstName.Text, textBoxLastName.Text, dateTimePicker.Value.ToString("dd.MM.yyyy"), textBoxEmail.Text, textBoxPhone.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vyplňtě všechny okna");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
