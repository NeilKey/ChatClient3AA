namespace ChatClient3AA
{
    partial class LoginForm
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
            this.user = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.UBox = new System.Windows.Forms.TextBox();
            this.PBox = new System.Windows.Forms.TextBox();
            this.checkUser = new System.Windows.Forms.CheckBox();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(32, 41);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(61, 13);
            this.user.TabIndex = 0;
            this.user.Text = "User name:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(35, 87);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(56, 13);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            // 
            // UBox
            // 
            this.UBox.Location = new System.Drawing.Point(121, 41);
            this.UBox.Name = "UBox";
            this.UBox.Size = new System.Drawing.Size(200, 20);
            this.UBox.TabIndex = 2;
            // 
            // PBox
            // 
            this.PBox.Location = new System.Drawing.Point(121, 87);
            this.PBox.Name = "PBox";
            this.PBox.PasswordChar = '•';
            this.PBox.Size = new System.Drawing.Size(200, 20);
            this.PBox.TabIndex = 3;
            // 
            // checkUser
            // 
            this.checkUser.AutoSize = true;
            this.checkUser.Location = new System.Drawing.Point(350, 43);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(78, 17);
            this.checkUser.TabIndex = 4;
            this.checkUser.Text = "save name";
            this.checkUser.UseVisualStyleBackColor = true;
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.Enabled = false;
            this.checkPassword.Location = new System.Drawing.Point(350, 89);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(97, 17);
            this.checkPassword.TabIndex = 5;
            this.checkPassword.Text = "save password";
            this.checkPassword.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(350, 210);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.BLClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(431, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.BCClick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 247);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.checkUser);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.UBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox UBox;
        private System.Windows.Forms.TextBox PBox;
        private System.Windows.Forms.CheckBox checkUser;
        private System.Windows.Forms.CheckBox checkPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
    }
}