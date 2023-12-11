namespace ditecProject_Kushan_E161088
{
	partial class Form4
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bankDataSet = new ditecProject_Kushan_E161088.bankDataSet();
			this.userAccountTableAdapter = new ditecProject_Kushan_E161088.bankDataSetTableAdapters.userAccountTableAdapter();
			this.bankDataSet1 = new ditecProject_Kushan_E161088.bankDataSet1();
			this.userAccountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.userAccountTableAdapter1 = new ditecProject_Kushan_E161088.bankDataSet1TableAdapters.userAccountTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(527, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "All Customers";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.nICDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userAccountBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(27, 128);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1122, 443);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// accountNoDataGridViewTextBoxColumn
			// 
			this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "Account_No";
			this.accountNoDataGridViewTextBoxColumn.HeaderText = "Account_No";
			this.accountNoDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
			this.accountNoDataGridViewTextBoxColumn.Width = 150;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 150;
			// 
			// phoneNoDataGridViewTextBoxColumn
			// 
			this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
			this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
			this.phoneNoDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
			this.phoneNoDataGridViewTextBoxColumn.Width = 150;
			// 
			// nICDataGridViewTextBoxColumn
			// 
			this.nICDataGridViewTextBoxColumn.DataPropertyName = "NIC";
			this.nICDataGridViewTextBoxColumn.HeaderText = "NIC";
			this.nICDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.nICDataGridViewTextBoxColumn.Name = "nICDataGridViewTextBoxColumn";
			this.nICDataGridViewTextBoxColumn.Width = 150;
			// 
			// balanceDataGridViewTextBoxColumn
			// 
			this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
			this.balanceDataGridViewTextBoxColumn.HeaderText = "balance";
			this.balanceDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
			this.balanceDataGridViewTextBoxColumn.Width = 150;
			// 
			// userAccountBindingSource
			// 
			this.userAccountBindingSource.DataMember = "userAccount";
			this.userAccountBindingSource.DataSource = this.bankDataSet;
			// 
			// bankDataSet
			// 
			this.bankDataSet.DataSetName = "bankDataSet";
			this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userAccountTableAdapter
			// 
			this.userAccountTableAdapter.ClearBeforeFill = true;
			// 
			// bankDataSet1
			// 
			this.bankDataSet1.DataSetName = "bankDataSet1";
			this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userAccountBindingSource1
			// 
			this.userAccountBindingSource1.DataMember = "userAccount";
			this.userAccountBindingSource1.DataSource = this.bankDataSet1;
			// 
			// userAccountTableAdapter1
			// 
			this.userAccountTableAdapter1.ClearBeforeFill = true;
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1179, 611);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Name = "Form4";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "All_Customers";
			this.Load += new System.EventHandler(this.Form4_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private bankDataSet bankDataSet;
		private System.Windows.Forms.BindingSource userAccountBindingSource;
		private bankDataSetTableAdapters.userAccountTableAdapter userAccountTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nICDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
		private bankDataSet1 bankDataSet1;
		private System.Windows.Forms.BindingSource userAccountBindingSource1;
		private bankDataSet1TableAdapters.userAccountTableAdapter userAccountTableAdapter1;
	}
}