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
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
			loaddate();
		}

		private void loaddate()
		{
			//throw new NotImplementedException();
			Datelabel.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			bankEntities1 dbe = new bankEntities1();
			decimal b = Convert.ToDecimal(textBox1.Text);
			var item = (from u in dbe.userAccounts where u.Account_No == b select u).FirstOrDefault();
			decimal b1 = Convert.ToDecimal(item.balance);
			decimal totalbal = Convert.ToDecimal(textBox5.Text);
			decimal transferacc = Convert.ToDecimal(textBox4.Text);
			if (b1>totalbal){
				userAccount item2 = (from u in dbe.userAccounts where u.Account_No== transferacc select u).FirstOrDefault();
				item2.balance = item2.balance + totalbal;
				item.balance = item.balance - totalbal;
				
				Transfer transfer = new Transfer();
                     transfer.Account_No =   Convert.ToDecimal(textBox1.Text);
				transfer.ToTransfer = Convert.ToDecimal(textBox4.Text);
				transfer.Date = DateTime.UtcNow.ToString();
				transfer.NIC = textBox2.Text;
				transfer.balance = Convert.ToDecimal(textBox5.Text);
				dbe.Transfers.Add(transfer);
				dbe.SaveChanges();
				MessageBox.Show("Transfer Money Successfully");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bankEntities1 dbe = new bankEntities1();
			decimal b= Convert.ToDecimal(textBox1.Text);
			var item = (from u in dbe.userAccounts where u.Account_No ==b select u).FirstOrDefault();
	          textBox3.Text = Convert.ToString(item.balance);
			textBox2.Text = item.NIC;
			
		}
	}
}
