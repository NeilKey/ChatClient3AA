namespace ChatClient3AA
{
    partial class NewAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newAccountGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nicknameText = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newAccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAccountGroupBox
            // 
            this.newAccountGroupBox.Controls.Add(this.passwordText);
            this.newAccountGroupBox.Controls.Add(this.passwordLabel);
            this.newAccountGroupBox.Controls.Add(this.usernameText);
            this.newAccountGroupBox.Controls.Add(this.usernameLabel);
            this.newAccountGroupBox.Controls.Add(this.nicknameText);
            this.newAccountGroupBox.Controls.Add(this.nicknameLabel);
            this.newAccountGroupBox.Location = new System.Drawing.Point(14, 14);
            this.newAccountGroupBox.Name = "newAccountGroupBox";
            this.newAccountGroupBox.Size = new System.Drawing.Size(276, 132);
            this.newAccountGroupBox.TabIndex = 0;
            this.newAccountGroupBox.TabStop = false;
            this.newAccountGroupBox.Text = "New Account Data";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(76, 90);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(180, 20);
            this.passwordText.TabIndex = 5;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.TextChanged += new System.EventHandler(this.OnPasswordChanged);
            this.passwordText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPasswordKeyPress);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(12, 93);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(76, 60);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(180, 20);
            this.usernameText.TabIndex = 3;
            this.usernameText.TextChanged += new System.EventHandler(this.OnUsernameChanged);
            this.usernameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnUsernameKeyPress);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(12, 63);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // nicknameText
            // 
            this.nicknameText.Location = new System.Drawing.Point(76, 30);
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.Size = new System.Drawing.Size(180, 20);
            this.nicknameText.TabIndex = 1;
            this.nicknameText.TextChanged += new System.EventHandler(this.OnNicknameChanged);
            this.nicknameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNicknameKeyPress);
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.Location = new System.Drawing.Point(12, 33);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(58, 13);
            this.nicknameLabel.TabIndex = 0;
            this.nicknameLabel.Text = "Nickname:";
            // 
            // newAccountButton
            // 
            this.newAccountButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newAccountButton.Location = new System.Drawing.Point(164, 158);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(60, 23);
            this.newAccountButton.TabIndex = 1;
            this.newAccountButton.Text = "Create";
            this.newAccountButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(230, 158);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // NewAccountForm
            // 
            this.AcceptButton = this.newAccountButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 192);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.newAccountGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAccountForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Account";
            this.newAccountGroupBox.ResumeLayout(false);
            this.newAccountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newAccountGroupBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox nicknameText;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button cancelButton;
    }
}