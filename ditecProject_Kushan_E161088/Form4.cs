using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ditecProject_Kushan_E161088
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
			bindgrid();
		}

		private void bindgrid()
		{
			dataGridView1.AutoGenerateColumns = false;
			bankEntities1 bs = new bankEntities1();
			var Item = bs.userAccounts.ToList();
			dataGridView1.DataSource = Item;
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'bankDataSet1.userAccount' table. You can move, or remove it, as needed.
			this.userAccountTableAdapter1.Fill(this.bankDataSet1.userAccount);
			// TODO: This line of code loads data into the 'bankDataSet.userAccount' table. You can move, or remove it, as needed.
			this.userAccountTableAdapter.Fill(this.bankDataSet.userAccount);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
