using System;
using System.Data;
using System.Windows.Forms;

namespace ChatClient3AA
{
    public partial class ChatClientForm : Form
    {
        private Connect c;

        public ChatClientForm()
        {
            InitializeComponent();
            PopulateListView();

            c = new Connect();
        }

        private void ButtonInviaClicked(object sender, EventArgs e)
        {
            c.sendMessage(inviaBox.Text);
        }

        private void loginClick(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(c);
            loginForm.ShowDialog();
        }

        private void impostazioniClick(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void newAccountClick(object sender, EventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm(c);
            newAccountForm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void PopulateListView()
        {
            userListView.Items.Clear();
            DataTable myDataTable;

            foreach (DataRow row in myDataTable.Rows)
            {
                // userListView.Items.Add();
            }
        }
    }
}
