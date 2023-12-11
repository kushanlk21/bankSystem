using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ditecProject_Kushan_E161088
{
	public partial class Form3 : Form
	{
		string gender = string.Empty;
		string m_status = string.Empty;
		decimal no;
		bankEntities1 BSE;
		MemoryStream ms;
		public Form3()
		{
			InitializeComponent();
			loaddate();
			loadaccount();
			loadstatus();
		}

		private void loaddate()
		{
			Datelabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
		}

		private void loadaccount()
		{
			BSE = new bankEntities1();
               var item = BSE.userAccounts.ToArray();
			no = item.LastOrDefault().Account_No + 1;
			textBox1.Text = Convert.ToString(no);
		}

		private void loadstatus()
		{
			comboBox1.Items.Add("Western");
			comboBox1.Items.Add("Northern");
			comboBox1.Items.Add("Southern");
			comboBox1.Items.Add("Eastern");
			comboBox1.Items.Add("North-Western");
			comboBox1.Items.Add("North-Central");
			comboBox1.Items.Add("Central");
			comboBox1.Items.Add("Uva");
			comboBox1.Items.Add("Sabaragamuwa");
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openbdlg = new OpenFileDialog();
            if (openbdlg.ShowDialog()==DialogResult.OK)
            {
               Image img = Image.FromFile(openbdlg.FileName);
			pictureBox1.Image = img;
			ms= new MemoryStream();
			img.Save(ms, img.RawFormat);
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked){
				gender = "Male";
			}
               else if(radioButton2.Checked){
				gender = "Female";
			}
               else if(radioButton3.Checked){
				gender = "Others";
			}
			if(radioButton4.Checked){
				m_status = "Married";

			}
			else if (radioButton5.Checked){
				m_status = "Unmarried";
			}
			BSE = new bankEntities1();
			
			userAccount acc = new userAccount();
               acc.Account_No = Convert.ToDecimal(textBox1.Text);
			acc.Name = Convert.ToString(textBox2.Text);
			acc.DOB = dateTimePicker1.Value.ToString();
			acc.PhoneNo = Convert.ToString(textBox3.Text);
			acc.Address = Convert.ToString(textBox4.Text);
			acc.NIC = Convert.ToString(textBox5.Text);
			acc.District = Convert.ToString(textBox6.Text);
			acc.Status = comboBox1.SelectedItem.ToString();
			acc.Gender = gender;
			acc.maritial_status = m_status;
			acc.Mother_name = Convert.ToString(textBox7.Text);
			acc.Father_name = Convert.ToString(textBox8.Text);
			acc.balance = Convert.ToDecimal(textBox9.Text);
			acc.Date = Datelabel.Text;
               acc.Picture = ms.ToArray();
			BSE.userAccounts.Add(acc);
			BSE.SaveChanges();
			MessageBox.Show("File Saved");
			

		}
	}
}
