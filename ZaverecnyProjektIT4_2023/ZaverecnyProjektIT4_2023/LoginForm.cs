using System.Data.SqlClient;
namespace ZaverecnyProjektIT4_2023
{
    public partial class LoginForm : Form
    {
        SqlRepository sql;
        public LoginForm()
        {
            InitializeComponent();
            sql = new SqlRepository();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = sql.LoginUser(txtUsername.Text.Trim());
            if (user != null)
            {
                if (user.VerifyPassword(txtPassword.Text))
                {
                    if (user.Role == "admin")
                    {
                        AdminForm admin = new AdminForm(user);
                        admin.Show();
                        this.Hide();
                        return;
                    }
                    else if (user.Role == "user") ;
                    {
                        UserForm userF = new UserForm(user);
                        userF.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Username or password incorrect.");
        }
    }
}