﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ditecProject_Kushan_E161088
{
	public partial class Form11 : Form
	{
		public Form11()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bankEntities1 dbe = new bankEntities1();
			decimal b = Convert.ToDecimal(textBox1.Text);
			var item = (from u in dbe.debits where u.Account_No == b select u);
			dataGridView1.DataSource = item.ToList();
			var item2 = (from u in dbe.Deposits where u.AccountNo == b select u);
               dataGridView2.DataSource = item2.ToList();
			var item3 = (from u in dbe.Transfers where u.Account_No==b select u);
	          dataGridView3.DataSource = item3.ToList();
			

		}
	}
}
