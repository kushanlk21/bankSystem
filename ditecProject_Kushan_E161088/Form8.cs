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
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();
			loaddate();
			loadmode();
		}

		private void loadmode()
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

		private void button1_Click(object sender, EventArgs e)
		{
			bankEntities1 dbe = new bankEntities1();
			decimal acc = Convert.ToDecimal(textBox1.Text);
			var accounts = dbe.userAccounts.Where(x => x.Account_No == acc).SingleOrDefault();
			FD fdform = new FD();
			fdform.Account_No = Convert.ToDecimal(textBox1.Text);
			fdform.Mode = comboBox1.SelectedItem.ToString();
			fdform.Rupees = textBox2.Text;
			fdform.Period = Convert.ToInt32(textBox3.Text);
			fdform.Interest_rate = Convert.ToDecimal(textBox4.Text);
			fdform.Start_Date = DateTime.UtcNow.ToString("dd/MM/yyyy");
			fdform.Maturity_Date = DateTime.UtcNow.AddDays(Convert.ToInt32(textBox3.Text)).ToString("dd/MM/yyyy");
			fdform.Maturity_Amount = ((Convert.ToDecimal(textBox2.Text) * Convert.ToInt32(textBox3.Text) * Convert.ToDecimal(textBox4.Text)) /
			  (100 * 12 * 30)) + (Convert.ToDecimal(textBox2.Text));
			dbe.FDs.Add(fdform);
			decimal amount = Convert.ToDecimal(textBox2.Text);
			decimal totalamount = Convert.ToDecimal(accounts.balance);
			decimal fdamount = totalamount-amount;
			accounts.balance = fdamount;


			dbe.SaveChanges();
			MessageBox.Show("FD Start Now");
		}
	}
}
