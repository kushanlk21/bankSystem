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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bankEntities1 dbe = new bankEntities1();
			if (textBox1.Text!=string.Empty || textBox2.Text!=string.Empty) {
				var user1= dbe.admins.FirstOrDefault(a=>a.username.Equals(textBox1.Text));
                    if (user1!=null) 
				{
					if(user1.password.Equals(textBox2.Text)){
						Form2 m1= new Form2();
						m1.ShowDialog();
					}
                         else{
						MessageBox.Show("Password incorrect");
					}
				}
				else{
					MessageBox.Show("Null Value");
				}
			}
			else 
			{
				MessageBox.Show("Please Enter Username and Password");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
