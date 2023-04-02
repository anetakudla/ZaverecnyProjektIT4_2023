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
        public AdminForm(User user)
        {
            InitializeComponent();
            sql = new SqlRepository();

            label10.Text = user.Username + " / " + user.Role;

            LoadUsers();
        }

        public void LoadUsers()
        {
            users = sql.GetUsers(textBoxSearchUser.Text);
            listViewUsers.Items.Clear();
            listViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
          
            foreach (var user in users)
            {
                listViewUsers.Items.Add(user.ToListViewItem());
            }
        }
    }
}
