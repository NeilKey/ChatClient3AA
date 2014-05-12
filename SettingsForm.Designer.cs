namespace ChatClient3AA
{
    partial class SettingsForm
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
            this.convGroupBox = new System.Windows.Forms.GroupBox();
            this.convOutColor_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.convOutFontButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.convInColor_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.convInFontButton = new System.Windows.Forms.Button();
            this.convInColorButton = new System.Windows.Forms.Button();
            this.OutGroupBox = new System.Windows.Forms.GroupBox();
            this.outTextColor_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textFontButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.langComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.convGroupBox.SuspendLayout();
            this.OutGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // convGroupBox
            // 
            this.convGroupBox.Controls.Add(this.convOutColor_lbl);
            this.convGroupBox.Controls.Add(this.label5);
            this.convGroupBox.Controls.Add(this.button5);
            this.convGroupBox.Controls.Add(this.label4);
            this.convGroupBox.Controls.Add(this.convOutFontButton);
            this.convGroupBox.Controls.Add(this.button4);
            this.convGroupBox.Controls.Add(this.convInColor_lbl);
            this.convGroupBox.Controls.Add(this.label1);
            this.convGroupBox.Controls.Add(this.convInFontButton);
            this.convGroupBox.Controls.Add(this.convInColorButton);
            this.convGroupBox.Location = new System.Drawing.Point(23, 13);
            this.convGroupBox.Name = "convGroupBox";
            this.convGroupBox.Size = new System.Drawing.Size(377, 176);
            this.convGroupBox.TabIndex = 0;
            this.convGroupBox.TabStop = false;
            this.convGroupBox.Text = "Conversation messages";
            // 
            // convOutColor_lbl
            // 
            this.convOutColor_lbl.AutoSize = true;
            this.convOutColor_lbl.BackColor = System.Drawing.Color.White;
            this.convOutColor_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convOutColor_lbl.Location = new System.Drawing.Point(205, 53);
            this.convOutColor_lbl.MinimumSize = new System.Drawing.Size(120, 80);
            this.convOutColor_lbl.Name = "convOutColor_lbl";
            this.convOutColor_lbl.Size = new System.Drawing.Size(120, 80);
            this.convOutColor_lbl.TabIndex = 11;
            this.convOutColor_lbl.Text = "Sample 123";
            this.convOutColor_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Background:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(126, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Color";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Outgoing:";
            // 
            // convOutFontButton
            // 
            this.convOutFontButton.Location = new System.Drawing.Point(321, 22);
            this.convOutFontButton.Name = "convOutFontButton";
            this.convOutFontButton.Size = new System.Drawing.Size(42, 23);
            this.convOutFontButton.TabIndex = 8;
            this.convOutFontButton.Text = "Font";
            this.convOutFontButton.UseVisualStyleBackColor = true;
            this.convOutFontButton.Click += new System.EventHandler(this.onOutFontButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Color";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onOutColorButton);
            // 
            // convInColor_lbl
            // 
            this.convInColor_lbl.AutoSize = true;
            this.convInColor_lbl.BackColor = System.Drawing.Color.White;
            this.convInColor_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convInColor_lbl.Location = new System.Drawing.Point(15, 53);
            this.convInColor_lbl.MinimumSize = new System.Drawing.Size(120, 80);
            this.convInColor_lbl.Name = "convInColor_lbl";
            this.convInColor_lbl.Size = new System.Drawing.Size(120, 80);
            this.convInColor_lbl.TabIndex = 1;
            this.convInColor_lbl.Text = "Sample 123";
            this.convInColor_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Incoming:";
            // 
            // convInFontButton
            // 
            this.convInFontButton.Location = new System.Drawing.Point(126, 22);
            this.convInFontButton.Name = "convInFontButton";
            this.convInFontButton.Size = new System.Drawing.Size(42, 23);
            this.convInFontButton.TabIndex = 3;
            this.convInFontButton.Text = "Font";
            this.convInFontButton.UseVisualStyleBackColor = true;
            this.convInFontButton.Click += new System.EventHandler(this.onInFontButton);
            // 
            // convInColorButton
            // 
            this.convInColorButton.Location = new System.Drawing.Point(77, 22);
            this.convInColorButton.Name = "convInColorButton";
            this.convInColorButton.Size = new System.Drawing.Size(42, 23);
            this.convInColorButton.TabIndex = 2;
            this.convInColorButton.Text = "Color";
            this.convInColorButton.UseVisualStyleBackColor = true;
            this.convInColorButton.Click += new System.EventHandler(this.onInColorButton);
            // 
            // OutGroupBox
            // 
            this.OutGroupBox.Controls.Add(this.outTextColor_lbl);
            this.OutGroupBox.Controls.Add(this.label6);
            this.OutGroupBox.Controls.Add(this.label8);
            this.OutGroupBox.Controls.Add(this.textFontButton);
            this.OutGroupBox.Controls.Add(this.button8);
            this.OutGroupBox.Controls.Add(this.button7);
            this.OutGroupBox.Location = new System.Drawing.Point(23, 195);
            this.OutGroupBox.Name = "OutGroupBox";
            this.OutGroupBox.Size = new System.Drawing.Size(377, 153);
            this.OutGroupBox.TabIndex = 11;
            this.OutGroupBox.TabStop = false;
            this.OutGroupBox.Text = "Outgoing message";
            // 
            // outTextColor_lbl
            // 
            this.outTextColor_lbl.AutoSize = true;
            this.outTextColor_lbl.BackColor = System.Drawing.Color.White;
            this.outTextColor_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outTextColor_lbl.Location = new System.Drawing.Point(15, 61);
            this.outTextColor_lbl.MinimumSize = new System.Drawing.Size(120, 80);
            this.outTextColor_lbl.Name = "outTextColor_lbl";
            this.outTextColor_lbl.Size = new System.Drawing.Size(120, 80);
            this.outTextColor_lbl.TabIndex = 12;
            this.outTextColor_lbl.Text = "Sample 123";
            this.outTextColor_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Text:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Background:";
            // 
            // textFontButton
            // 
            this.textFontButton.Location = new System.Drawing.Point(126, 26);
            this.textFontButton.Name = "textFontButton";
            this.textFontButton.Size = new System.Drawing.Size(42, 23);
            this.textFontButton.TabIndex = 14;
            this.textFontButton.Text = "Font";
            this.textFontButton.UseVisualStyleBackColor = true;
            this.textFontButton.Click += new System.EventHandler(this.onTextFontButton);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(272, 26);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Color";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(77, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Color";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.onTextColorButton);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.langComboBox);
            this.groupBox3.Location = new System.Drawing.Point(406, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Language:";
            // 
            // langComboBox
            // 
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.Items.AddRange(new object[] {
            "English",
            "Italian"});
            this.langComboBox.Location = new System.Drawing.Point(20, 27);
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(158, 21);
            this.langComboBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.portTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.hostnameTextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(406, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 98);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Host:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(86, 56);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Host Port:";
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Location = new System.Drawing.Point(86, 27);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostnameTextBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Host Name:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(472, 353);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(65, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.onSaveButton);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(543, 353);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Cancel";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.onCancel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatClient3AA.Properties.Resources.ChatIcons;
            this.pictureBox1.Location = new System.Drawing.Point(440, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 388);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OutGroupBox);
            this.Controls.Add(this.convGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.onSettingFormLoad);
            this.convGroupBox.ResumeLayout(false);
            this.convGroupBox.PerformLayout();
            this.OutGroupBox.ResumeLayout(false);
            this.OutGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox convGroupBox;
        private System.Windows.Forms.Label convInColor_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convInFontButton;
        private System.Windows.Forms.Button convInColorButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button convOutFontButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox OutGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button textFontButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox langComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label convOutColor_lbl;
        private System.Windows.Forms.Label outTextColor_lbl;
    }
}