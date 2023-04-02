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
    public partial class AddWork : Form
    {
        SqlRepository sql;
        public AddWork()
        {
            InitializeComponent();
            sql = new SqlRepository();
        }

        private void buttonAddWork_Click(object sender, EventArgs e)
        {
             if (textBoxName.Text != "" && textBoxDescription.Text != "")
            {
                sql.AddWork(textBoxName.Text, textBoxDescription.Text);
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
