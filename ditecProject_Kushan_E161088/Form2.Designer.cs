namespace ditecProject_Kushan_E161088
{
	partial class Form2
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateSearchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.widthdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fDFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.balanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewFDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.othersToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1094, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// accountToolStripMenuItem
			// 
			this.accountToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.updateSearchAccountToolStripMenuItem,
            this.allCustomersToolStripMenuItem});
			this.accountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
			this.accountToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
			this.accountToolStripMenuItem.Text = "Account";
			this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
			// 
			// newAccountToolStripMenuItem
			// 
			this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
			this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(311, 34);
			this.newAccountToolStripMenuItem.Text = "New Account";
			this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
			// 
			// updateSearchAccountToolStripMenuItem
			// 
			this.updateSearchAccountToolStripMenuItem.Name = "updateSearchAccountToolStripMenuItem";
			this.updateSearchAccountToolStripMenuItem.Size = new System.Drawing.Size(311, 34);
			this.updateSearchAccountToolStripMenuItem.Text = "Update / Search Account";
			this.updateSearchAccountToolStripMenuItem.Click += new System.EventHandler(this.updateSearchAccountToolStripMenuItem_Click);
			// 
			// allCustomersToolStripMenuItem
			// 
			this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
			this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(311, 34);
			this.allCustomersToolStripMenuItem.Text = "All Customers";
			this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allCustomersToolStripMenuItem_Click);
			// 
			// transactionsToolStripMenuItem
			// 
			this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.widthdrawToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.fDFormToolStripMenuItem});
			this.transactionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
			this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
			this.transactionsToolStripMenuItem.Text = "Transactions";
			// 
			// depositToolStripMenuItem
			// 
			this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
			this.depositToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
			this.depositToolStripMenuItem.Text = "Deposit";
			this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
			// 
			// widthdrawToolStripMenuItem
			// 
			this.widthdrawToolStripMenuItem.Name = "widthdrawToolStripMenuItem";
			this.widthdrawToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
			this.widthdrawToolStripMenuItem.Text = "Widthdraw";
			this.widthdrawToolStripMenuItem.Click += new System.EventHandler(this.widthdrawToolStripMenuItem_Click);
			// 
			// transferToolStripMenuItem
			// 
			this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
			this.transferToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
			this.transferToolStripMenuItem.Text = "Transfer";
			this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
			// 
			// fDFormToolStripMenuItem
			// 
			this.fDFormToolStripMenuItem.Name = "fDFormToolStripMenuItem";
			this.fDFormToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
			this.fDFormToolStripMenuItem.Text = "FD Form";
			this.fDFormToolStripMenuItem.Click += new System.EventHandler(this.fDFormToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceSheetToolStripMenuItem,
            this.viewFDToolStripMenuItem});
			this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// balanceSheetToolStripMenuItem
			// 
			this.balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
			this.balanceSheetToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
			this.balanceSheetToolStripMenuItem.Text = "Balance Sheet";
			this.balanceSheetToolStripMenuItem.Click += new System.EventHandler(this.balanceSheetToolStripMenuItem_Click);
			// 
			// viewFDToolStripMenuItem
			// 
			this.viewFDToolStripMenuItem.Name = "viewFDToolStripMenuItem";
			this.viewFDToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
			this.viewFDToolStripMenuItem.Text = "View FD";
			this.viewFDToolStripMenuItem.Click += new System.EventHandler(this.viewFDToolStripMenuItem_Click);
			// 
			// othersToolStripMenuItem
			// 
			this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.othersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
			this.othersToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
			this.othersToolStripMenuItem.Text = "Others";
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
			this.logoutToolStripMenuItem.Text = "Logout";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
			this.changePasswordToolStripMenuItem.Text = "Change Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1094, 736);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateSearchAccountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem widthdrawToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fDFormToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem balanceSheetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewFDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}