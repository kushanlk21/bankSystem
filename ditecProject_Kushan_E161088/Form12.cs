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
	public partial class Form12 : Form
	{
		public Form12()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bankEntities1 dbe = new bankEntities1();
			if (textBox2.Text!=string.Empty || textBox3.Text!=string.Empty	|| textBox4.Text!=string.Empty ) 
			{ 
				admin user1 =dbe.admins.FirstOrDefault(a=>a.username.Equals(textBox1.Text));
				if (user1 != null) 
				{
					if (user1.password.Equals(textBox2.Text)) 
					{
						user1.password = textBox3.Text;
						dbe.SaveChanges();
						MessageBox.Show("Password Change Successfully");
					}
					else 
					{
						MessageBox.Show("Password Incorrect");
					}	
				}
			}
		}
	}
}
