using System;
using System.Windows.Forms;

namespace ChatClient3AA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String name = UBox.Text;
            String password = PBox.Text;

        }

        private void BLClick(object sender, EventArgs e)
        {

        }

        private void BCClick(object sender, EventArgs e)
        {
            UBox.Clear();
            PBox.Clear();
        }
    }
}
