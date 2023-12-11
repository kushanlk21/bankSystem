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
	public partial class Form5 : Form
	{
		string gender = string.Empty;
		string m_status = string.Empty;
		decimal no;
		bankEntities1 dbe;
		MemoryStream ms;
		BindingList<userAccount> bi;

		public Form5()
		{
			InitializeComponent();
			loadstatus();
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

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			bi = new BindingList<userAccount>();
			dbe = new bankEntities1();
               decimal accno = Convert.ToDecimal(textBox1.Text);
			var item  = dbe.userAccounts.Where(a=>a.Account_No == accno);
			foreach(var item1 in item ){
				bi.Add(item1);
			}
			dataGridView1.DataSource = bi;
		}

		private void Form5_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openbdlg = new OpenFileDialog();
			if (openbdlg.ShowDialog() == DialogResult.OK)
			{
				Image img = Image.FromFile(openbdlg.FileName);
				pictureBox1.Image = img;
				ms = new MemoryStream();
				img.Save(ms, img.RawFormat);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			bi = new BindingList<userAccount>();
			dbe = new bankEntities1();
			var item =dbe.userAccounts.Where(a=>a.NIC == textBox5.Text);
			foreach(var item1 in item ){ 
				bi.Add(item1 );	 
			
			}
			dataGridView1.DataSource = bi;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dbe = new bankEntities1();
			decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			var item = dbe.userAccounts.Where(a=> a.Account_No == accno).FirstOrDefault();
			textBox1.Text = item.Account_No.ToString();
			textBox2.Text = item.Name;
			textBox3.Text = item.PhoneNo;
			textBox4.Text = item.Address;
			textBox5.Text = item.NIC;
			textBox6.Text = item.District;
               textBox7.Text = item.Mother_name;
			textBox8.Text = item.Father_name;
			comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
			byte[] img = item.Picture;
			MemoryStream ms = new MemoryStream(img);
			pictureBox1.Image = Image.FromStream(ms);
			if(item.Gender=="Male"){
				radioButton1.Checked = true;
			}
			else if(item.Gender=="Female"){
                    radioButton2.Checked = true;
			}
			else if(item.Gender=="Others"){
                    radioButton3.Checked = true;
			}
			if(item.maritial_status=="Married"){
                    radioButton4.Checked = true;
			}
			else if( item.maritial_status=="Unmarried"){
                    radioButton5.Checked = true;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
			dbe = new bankEntities1();
			decimal a = Convert.ToDecimal(textBox1.Text);
			userAccount acc = dbe.userAccounts.First(s=>s.Account_No.Equals(a));
			dbe.userAccounts.Remove(acc);
			dbe.SaveChanges();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			dbe = new bankEntities1();
			decimal accontno= Convert.ToDecimal(textBox1.Text);
			userAccount userAccount = dbe.userAccounts.First(s => s.Account_No.Equals(accontno));
			userAccount.Account_No = Convert.ToDecimal(textBox1.Text);
			userAccount.Name = textBox2.Text;
			userAccount.Date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
			userAccount.PhoneNo = textBox3.Text;
			userAccount.Address = textBox4.Text;
			userAccount.NIC = textBox5.Text;
			userAccount.District= textBox6.Text;
			userAccount.Status = comboBox1.SelectedItem.ToString();
			userAccount.Mother_name = textBox7.Text;
			userAccount.Father_name = textBox8.Text;
			if (radioButton1.Checked == true)
			{
				gender = "Male";
			}
			else if (radioButton2.Checked == true)
			{
				gender = "Female";
			}
			else if (radioButton3.Checked == true)
			{
				gender = "Others";
			}
			if (radioButton4.Checked == true)
			{
				m_status = "Married";

			}
			else if (radioButton5.Checked == true)
			{
				m_status = "Unmarried";
			}
			
			Image img =pictureBox1.Image;
			if (img.RawFormat!= null) 
			{
				if(ms!=null)
				{
					img.Save(ms, img.RawFormat);
					userAccount.Picture = ms.ToArray();
				}
			}
			dbe.SaveChanges();
			MessageBox.Show("File Updated");
		}
	}
}
