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
    public partial class EditEmployee : Form
    {
        string id;
        SqlRepository sql;
        public EditEmployee(Employee employee)
        {
            InitializeComponent();
            sql = new SqlRepository();

            id = employee.EmployeeId.ToString();

            textBoxJob.Text = employee.Job;
            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            dateTimePicker.Value = employee.BirthDate;
            textBoxEmail.Text = employee.Email;
            textBoxPhone.Text = employee.Phone;
        }

        private void buttonEditWork_Click(object sender, EventArgs e)
        {
            if (textBoxJob.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxEmail.Text != "" && textBoxPhone.Text != "")
            {
                sql.EditEmployee(id, textBoxJob.Text, textBoxFirstName.Text, textBoxLastName.Text, dateTimePicker.Value.ToString("dd.MM.yyyy"), textBoxEmail.Text,textBoxPhone.Text);
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
