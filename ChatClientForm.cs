using System;
using System.Windows.Forms;

namespace ChatClient3AA
{
    public partial class ChatClientForm : Form
    {
        public ChatClientForm()
        {
            InitializeComponent();
        }

        private void ButtonInviaClicked(object sender, EventArgs e)
        {
            
        }

        private void loginClick(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void impostazioniClick(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void newAccountClick(object sender, EventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            newAccountForm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e){}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        private void richTextBox2_TextChanged(object sender, EventArgs e){}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
