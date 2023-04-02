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
    public partial class AddContract : Form
    {
        SqlRepository sql;
        public AddContract()
        {
            InitializeComponent();
            sql = new SqlRepository();
        }

        private void buttonAddContract_Click(object sender, EventArgs e)
        {
            if (textBoxWorkId.Text != "" && textBoxEmplyoeeId.Text != "" && textBoxCustomerName.Text != "" && textBoxHours.Text != "")
            {
                sql.AddContract(textBoxWorkId.Text,textBoxEmplyoeeId.Text,textBoxCustomerName.Text, dateTimePicker.Value.ToString("dd.MM.yyyy"), textBoxHours.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vyplňtě všechny okna");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
