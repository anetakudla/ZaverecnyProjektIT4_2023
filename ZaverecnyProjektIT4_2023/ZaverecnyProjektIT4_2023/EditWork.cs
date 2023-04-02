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
    public partial class EditWork : Form
    {
        string id;
        SqlRepository sql;
        public EditWork(Work work)
        {
            InitializeComponent();
            sql = new SqlRepository();

            id = work.WorkId.ToString();
            textBoxName.Text = work.Name;
            textBoxDescription.Text = work.Description;
        }

        private void buttonEditWork_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxDescription.Text != "")
            {
                sql.EditWork(id, textBoxName.Text, textBoxDescription.Text);
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
