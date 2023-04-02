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
    public partial class AdminForm : Form
    {
        SqlRepository sql;
        private User user;
        private List<User> users;
        private List<Employee> employees;
        private List<Work> works;
        private List<Contract> contracts;
        public AdminForm(User user)
        {
            InitializeComponent();
            sql = new SqlRepository();

            label10.Text = user.Username + " / " + user.Role;

            LoadUsers();
            LoadEmployees();
            LoadWorks();
            LoadConracts();
        }

        public void LoadUsers()
        {
            users = sql.GetUsers(textBoxSearchUser.Text);
            listViewUsers.Items.Clear();
          
            foreach (var user in users)
            {
                listViewUsers.Items.Add(user.ToListViewItem());
            }
            listViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void textBoxSearchUser_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            var result = addUser.ShowDialog();
            if (result == DialogResult.OK)
                LoadUsers();
        }
        private void buttonEditUser_Click(object sender, EventArgs e)
        {

        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {

            var row = listViewUsers.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sql.DeleteUser(Convert.ToInt32(id));
            listViewUsers.SelectedItems[0].Remove();

            LoadUsers();
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
        private void textBoxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        private void buttonAddEmployee_Click_1(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            var result = addEmployee.ShowDialog();
            if (result == DialogResult.OK)
                LoadEmployees();
        }
        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            var row = listViewEmployees.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sql.DeleteEmployee(Convert.ToInt32(id));
            listViewEmployees.SelectedItems[0].Remove();

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

        private void textBoxSearchWorks_TextChanged(object sender, EventArgs e)
        {
            LoadWorks();
        }
        private void buttonAddWork_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork();
            var result = addWork.ShowDialog();
            if (result == DialogResult.OK)
                LoadWorks();
        }
        private void buttonDeleteWork_Click(object sender, EventArgs e)
        {
            var row = listViewWorks.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sql.DeleteWork(Convert.ToInt32(id));
            listViewWorks.SelectedItems[0].Remove();

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
        private void textBoxSearchContacts_TextChanged(object sender, EventArgs e)
        {
            LoadConracts();
        }
        private void buttonAddContract_Click(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract();
            var result = addContract.ShowDialog();
            if (result == DialogResult.OK)
                LoadConracts();
        }
        private void buttonDeleteContract_Click(object sender, EventArgs e)
        {
            var row = listViewContracts.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sql.DeleteContract(Convert.ToInt32(id));
            listViewContracts.SelectedItems[0].Remove();

            LoadConracts();
        }
    }
}
