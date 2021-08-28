using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAT_1_college__fest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dharamraj bhatt\Source\Repos\CAT-1-college -fest\CAT-1-college -fest\collegefestmdf.mdf;Integrated Security=True");
            SqlDataReader dr = null;
            cn.Open();
            /*SqlDataReader dr = cmd.ExecuteReader();*/

            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from registration_1947216 where email='" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Successfully logged in");

                    this.Hide();
                    Form  f3 = new Form3();
                    f3.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4();
            f2.ShowDialog();
        }
    }
}
