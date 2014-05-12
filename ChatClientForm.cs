using System.Windows.Forms;

namespace ChatClient3AA
{
    public partial class ChatClientForm : Form
    {
        public ChatClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SettingsForm dlg = new SettingsForm();
            dlg.ShowDialog();
        }
    }
}
