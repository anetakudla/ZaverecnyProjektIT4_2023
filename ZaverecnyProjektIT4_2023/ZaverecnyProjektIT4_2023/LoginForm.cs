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
        }
    }
}