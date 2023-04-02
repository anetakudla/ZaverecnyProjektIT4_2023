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
        public AdminForm(User user)
        {
            InitializeComponent();
            sql = new SqlRepository();

            label10.Text = user.Username + " / " + user.Role;

            LoadUsers();
            LoadEmployees();
            LoadWorks();
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
    }
}
