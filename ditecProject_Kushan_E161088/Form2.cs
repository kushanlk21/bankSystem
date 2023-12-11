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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form3 m1 = new Form3();
			m1.MdiParent = this;
               m1.Show();
		}

		private void accountToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form4 m1 =new Form4();
			m1.MdiParent = this;
			m1.Show();
		}

		private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form5 m1 =new Form5();
			m1.MdiParent = this;
			m1.Show();
		}

		private void depositToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form6 m1 =new Form6();
			m1.MdiParent = this;	
			m1.Show();
		}

		private void transferToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form7 m1 = new Form7();
			m1.MdiParent = this;
			m1.Show();
		}

		private void fDFormToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form8 m1 = new Form8();
			m1.MdiParent = this;
			m1.Show();
		}

		private void widthdrawToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form9 m1 = new Form9();
			m1.MdiParent = this;
			m1.Show();
		}

		private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form10 m1 = new Form10();
			m1.MdiParent = this;
			m1.Show();
		}

		private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form11 m1 = new Form11();
			m1.MdiParent = this;
			m1.Show();
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form12 m1 = new Form12();
			m1.MdiParent = this;
			m1.Show();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}
	}
}
