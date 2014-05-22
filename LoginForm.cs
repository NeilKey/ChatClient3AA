using ChatClient3AA.Properties;
using System;
using System.Windows.Forms;

namespace ChatClient3AA
{
    public partial class LoginForm : Form
    {
        Connect c = new Connect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Commento
            String name = UBox.Text;
            String password = PBox.Text;

        }

        private void BCClick(object sender, EventArgs e)
        {
            UBox.Clear();
            PBox.Clear();
        }

        private void login(object sender, EventArgs e)
        {
            if(checkUser.CheckState != null)
            {
                Settings.Default.Username = UBox.Text;
            }
            if (checkPassword.CheckState != null)
            {
                Settings.Default.Passworduser = PBox.Text;
            }
            
            String user_name = UBox.Text;
            String password = PBox.Text;
            c.loginUser(user_name, password);
        }

        
    }
}
