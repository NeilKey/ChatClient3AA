using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatClient3AA
{
    public partial class NewAccountForm : Form
    {
        private Connect c;
        public NewAccountForm(Connect c)
        {
            // Commento
            InitializeComponent();

            // Aggiorna lo stato del button Create
            UpdateCreateButtonState();

            this.c = c;
        }

        private void UpdateCreateButtonState()
        {
            // Abilita il button di Create solo se i campi nickname, username e password non sono vuoti
            this.newAccountButton.Enabled = (this.nicknameText.Text.Length > 0 &&
                this.usernameText.Text.Length > 0 &&
                this.passwordText.Text.Length > 0) ? true : false;
        }

        private void OnNicknameChanged(object sender, EventArgs e)
        {
            // Il campo nickname è stato modificato, aggiorna lo stato del button Create
            UpdateCreateButtonState();
        }

        private void OnNicknameKeyPress(object sender, KeyPressEventArgs e)
        {
            // Filtra i caratteri ':' e ',' (non permessi)
            if (e.KeyChar == ':' || e.KeyChar == ',')
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void OnUsernameChanged(object sender, EventArgs e)
        {
            // Il campo username è stato modificato, aggiorna lo stato del button Create
            UpdateCreateButtonState();
        }

        private void OnUsernameKeyPress(object sender, KeyPressEventArgs e)
        {
            // Filtra i caratteri ':' e ',' (non permessi)
            if (e.KeyChar == ':' || e.KeyChar == ',')
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            // Il campo password è stato modificato, aggiorna lo stato del button Create
            UpdateCreateButtonState();
        }

        private void OnPasswordKeyPress(object sender, KeyPressEventArgs e)
        {
            // Filtra i caratteri ':' e ',' (non permessi)
            if (e.KeyChar == ':' || e.KeyChar == ',')
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        // Accessors ai tre campi nickname, username e password
        public string Nickname
        {
            get { return this.nicknameText.Text; }
        }

        public string Username
        {
            get { return this.usernameText.Text; }
        }

        public string Password
        {
            get { return this.passwordText.Text; }
        }

        private void NewAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void newAccountGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Create(object sender, EventArgs e)
        {
            String nick_name = nicknameText.Text;
            String user_name = usernameText.Text;
            String password = passwordText.Text;
            c.createNewAccount(nick_name,user_name,password);
        }
    }
}
