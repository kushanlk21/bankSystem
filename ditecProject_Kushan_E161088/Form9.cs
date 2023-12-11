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
	public partial class Form9 : Form
	{
		public Form9()
		{
			InitializeComponent();
			loadcombo();
			loaddate();
		}

		private void loadcombo()
		{
			//throw new NotImplementedException();
			comboBox1.Items.Add("Cash");
			comboBox1.Items.Add("Chque");
		
		}

		private void loaddate()
		{
			//throw new NotImplementedException();
			Datelabel.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			retrivedata();
		}

		private void retrivedata()
		{
			bankEntities1 dbe = new bankEntities1();
			decimal b = Convert.ToDecimal(textBox1.Text);
			var item = (from u in dbe.userAccounts where u.Account_No == b select u).FirstOrDefault();
			textBox2.Text = item.NIC;
			textBox3.Text = Convert.ToString(item.balance);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			savedata();
		}

		private void savedata()
		{
			bankEntities1 dbe = new bankEntities1();
			Form3 nacc = new Form3();
			debit dp = new debit();
			dp.Date = Datelabel.Text;
			dp.Account_No = Convert.ToDecimal(textBox1.Text);
			dp.NIC = textBox2.Text;
			dp.OldBalance = Convert.ToDecimal(textBox3.Text);
			dp.Mode = comboBox1.SelectedItem.ToString();
			dp.DebAmount = Convert.ToDecimal(textBox4.Text);
			dbe.debits.Add(dp);
			dbe.SaveChanges();
			decimal b = Convert.ToDecimal(textBox1.Text);
			var item = (from u in dbe.userAccounts where u.Account_No == b select u).FirstOrDefault();
			item.balance = item.balance - Convert.ToDecimal(textBox4.Text);
			dbe.SaveChanges();
			MessageBox.Show("Debit Money");
		}
	}
}
