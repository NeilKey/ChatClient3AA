namespace ChatClient3AA
{
    partial class ChatClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatClientForm));
            this.riceviBox = new System.Windows.Forms.RichTextBox();
            this.buttonInvia = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.loginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoAccountStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.impostazioniStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.userView = new System.Windows.Forms.ListView();
            this.principalContainer = new System.Windows.Forms.SplitContainer();
            this.userListView = new System.Windows.Forms.ListView();
            this.userColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.verticalBoxContainer = new System.Windows.Forms.SplitContainer();
            this.inviaBox = new System.Windows.Forms.RichTextBox();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.principalContainer.Panel1.SuspendLayout();
            this.principalContainer.Panel2.SuspendLayout();
            this.principalContainer.SuspendLayout();
            this.verticalBoxContainer.Panel1.SuspendLayout();
            this.verticalBoxContainer.Panel2.SuspendLayout();
            this.verticalBoxContainer.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // riceviBox
            // 
            this.riceviBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.riceviBox, "riceviBox");
            this.riceviBox.Name = "riceviBox";
            // 
            // buttonInvia
            // 
            resources.ApplyResources(this.buttonInvia, "buttonInvia");
            this.buttonInvia.Name = "buttonInvia";
            this.buttonInvia.UseVisualStyleBackColor = true;
            this.buttonInvia.Click += new System.EventHandler(this.ButtonInviaClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginStrip,
            this.nuovoAccountStrip,
            this.impostazioniStrip});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // loginStrip
            // 
            this.loginStrip.Name = "loginStrip";
            resources.ApplyResources(this.loginStrip, "loginStrip");
            this.loginStrip.Click += new System.EventHandler(this.loginClick);
            // 
            // nuovoAccountStrip
            // 
            this.nuovoAccountStrip.Name = "nuovoAccountStrip";
            resources.ApplyResources(this.nuovoAccountStrip, "nuovoAccountStrip");
            this.nuovoAccountStrip.Click += new System.EventHandler(this.newAccountClick);
            // 
            // impostazioniStrip
            // 
            this.impostazioniStrip.Name = "impostazioniStrip";
            resources.ApplyResources(this.impostazioniStrip, "impostazioniStrip");
            this.impostazioniStrip.Click += new System.EventHandler(this.impostazioniClick);
            // 
            // userView
            // 
            resources.ApplyResources(this.userView, "userView");
            this.userView.Name = "userView";
            this.userView.UseCompatibleStateImageBehavior = false;
            // 
            // principalContainer
            // 
            resources.ApplyResources(this.principalContainer, "principalContainer");
            this.principalContainer.Name = "principalContainer";
            // 
            // principalContainer.Panel1
            // 
            this.principalContainer.Panel1.Controls.Add(this.userListView);
            this.principalContainer.Panel1.Controls.Add(this.userView);
            // 
            // principalContainer.Panel2
            // 
            this.principalContainer.Panel2.Controls.Add(this.verticalBoxContainer);
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userColumnHeader});
            resources.ApplyResources(this.userListView, "userListView");
            this.userListView.Name = "userListView";
            this.userListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.SelectedIndexChanged += new System.EventHandler(this.userListView_SelectedIndexChanged);
            // 
            // userColumnHeader
            // 
            resources.ApplyResources(this.userColumnHeader, "userColumnHeader");
            // 
            // verticalBoxContainer
            // 
            resources.ApplyResources(this.verticalBoxContainer, "verticalBoxContainer");
            this.verticalBoxContainer.Name = "verticalBoxContainer";
            // 
            // verticalBoxContainer.Panel1
            // 
            this.verticalBoxContainer.Panel1.Controls.Add(this.riceviBox);
            // 
            // verticalBoxContainer.Panel2
            // 
            this.verticalBoxContainer.Panel2.Controls.Add(this.inviaBox);
            this.verticalBoxContainer.Panel2.Controls.Add(this.buttonPanel);
            // 
            // inviaBox
            // 
            this.inviaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.inviaBox, "inviaBox");
            this.inviaBox.Name = "inviaBox";
            this.inviaBox.ShowSelectionMargin = true;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.buttonInvia);
            resources.ApplyResources(this.buttonPanel, "buttonPanel");
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ChatClientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.principalContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "ChatClientForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.principalContainer.Panel1.ResumeLayout(false);
            this.principalContainer.Panel2.ResumeLayout(false);
            this.principalContainer.ResumeLayout(false);
            this.verticalBoxContainer.Panel1.ResumeLayout(false);
            this.verticalBoxContainer.Panel2.ResumeLayout(false);
            this.verticalBoxContainer.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox riceviBox;
        private System.Windows.Forms.Button buttonInvia;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem loginStrip;
        private System.Windows.Forms.ToolStripMenuItem nuovoAccountStrip;
        private System.Windows.Forms.ToolStripMenuItem impostazioniStrip;
        private System.Windows.Forms.ListView userView;
        private System.Windows.Forms.SplitContainer principalContainer;
        private System.Windows.Forms.SplitContainer verticalBoxContainer;
        private System.Windows.Forms.RichTextBox inviaBox;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader userColumnHeader;
    }
}

