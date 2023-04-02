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
    public partial class UserForm : Form
    {
        SqlRepository sql;
        private List<User> users;
        private List<Employee> employees;
        private List<Work> works;
        private List<Contract> contracts;
        public UserForm(User user)
        {
            InitializeComponent();
            sql = new SqlRepository();

            label10.Text = user.Username + " / " + user.Role;

            LoadEmployees();
            LoadWorks();
            LoadConracts();
        }
        public void LoadEmployees()
        {
            employees = sql.GetEmployees(textBoxSearchEmployee.Text);
            listViewEmployees.Items.Clear();

            foreach (var employee in employees)
            {
                listViewEmployees.Items.Add(employee.ToListViewItem());
            }
            listViewEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
       private void textBoxSearchEmployee_TextChanged_1(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        public void LoadWorks()
        {
            works = sql.GetWorks(textBoxSearchWorks.Text);
            listViewWorks.Items.Clear();

            foreach (var work in works)
            {
                listViewWorks.Items.Add(work.ToListViewItem());
            }
            listViewWorks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewWorks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void textBoxSearchWorks_TextChanged_1(object sender, EventArgs e)
        {
            LoadWorks();
        }
        public void LoadConracts()
        {
            contracts = sql.GetContracts(textBoxSearchContacts.Text);
            listViewContracts.Items.Clear();

            foreach (var contract in contracts)
            {
                listViewContracts.Items.Add(contract.ToListViewItem());
            }
            listViewContracts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewContracts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void textBoxSearchContacts_TextChanged_1(object sender, EventArgs e)
        {
            LoadConracts();
        }
        private void buttonAddContract_Click_1(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract();
            var result = addContract.ShowDialog();
            if (result == DialogResult.OK)
                LoadConracts();
        }

        private void buttonDeleteContract_Click_1(object sender, EventArgs e)
        {
            var row = listViewContracts.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sql.DeleteContract(Convert.ToInt32(id));
            listViewContracts.SelectedItems[0].Remove();

            LoadConracts();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
