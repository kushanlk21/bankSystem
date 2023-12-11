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
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
			loaddate();
			loademode();
		}

		private void loademode()
		{
			//throw new NotImplementedException();
			label7.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
		}

		private void loaddate()
		{
			//throw new NotImplementedException();
			comboBox1.Items.Add("Cash");
			comboBox1.Items.Add("Chque");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bankEntities1 context = new bankEntities1();
			decimal b = Convert.ToDecimal(textBox1.Text);
			var item = (from u in context.userAccounts where u.Account_No == b select u).FirstOrDefault();
			textBox2.Text = item.NIC;
			textBox3.Text = Convert.ToString(item.balance);



		}

		private void button2_Click(object sender, EventArgs e)
		{
			

			bankEntities1 context = new bankEntities1();
			Form3 acc = new Form3();
			Deposit dp = new Deposit();
			dp.Date = label7.Text;
			dp.AccountNo = Convert.ToDecimal(textBox1.Text);
			dp.NIC = textBox2.Text;
			dp.OldBalance = Convert.ToDecimal(textBox3.Text);
			dp.Mode = comboBox1.SelectedItem.ToString();
			dp.DipAmount = Convert.ToDecimal(textBox4.Text);
			context.Deposits.Add(dp);
			context.SaveChanges();
			decimal b = Convert.ToDecimal(textBox1.Text);
			var item = (from u in context.userAccounts where u.Account_No == b select u).FirstOrDefault();
			item.balance = item.balance + Convert.ToDecimal(textBox4.Text);
			context.SaveChanges();
			MessageBox.Show("Deposit Money Successfully");
		}
	}
}
