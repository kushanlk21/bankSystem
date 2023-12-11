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
	public partial class Form10 : Form
	{
		BindingList<FD> bl;
		bankEntities1 dbe;
		public Form10()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bl = new BindingList<FD>();
			dbe = new bankEntities1();
			string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
			MessageBox.Show(date);
			var item = dbe.FDs.Where(a=>a.Start_Date.Equals(date));
			dataGridView1.DataSource = item.ToList();
		}
	}
}
