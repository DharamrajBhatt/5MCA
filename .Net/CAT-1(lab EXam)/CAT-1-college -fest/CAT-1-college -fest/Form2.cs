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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            String department;
            var nullValue = DBNull.Value;
            String pass1 = textBox4.Text;
            String pass2 = textBox5.Text;
            String name = textBox1.Text;
            String email = textBox2.Text;
            String c_name = textBox3.Text;
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Name can't be Empty");
                textBox1.Focus();
                return;
            }
           
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Email can't be Empty");
                return;
            }

            else if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("college Name can't be Empty");
                return;
            }

            else if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                MessageBox.Show("select atlest one department");
                return;
            }

            
            else if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("password can't be Empty");
                textBox4.Focus();
                return;
            }
            else if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("confirm password can't be Empty");
                textBox5.Focus();
                return;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    department = "MCA";
                }
                else if (radioButton2.Checked)
                {
                    department = "MSc";

                }
                else
                {
                    department = "Others";
                }

                if (!pass1.Equals(pass2))
                {
                    MessageBox.Show("Password doesn't match", "please ReEnter passwords again");
                }
                else
                {



                    SqlConnection cnn = new SqlConnection();
                    SqlCommand com = new SqlCommand();
                    cnn.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dharamraj bhatt\Source\Repos\CAT-1-college -fest\CAT-1-college -fest\collegefestmdf.mdf;Integrated Security=True");
                    cnn.Open();
                    com.Connection = cnn;
                    com.CommandText = ("INSERT INTO registration_1947216 (name,email,c_name,department,event,password) VALUES ('" + name + "','" + email + "','" + c_name + "','" + department + "','" + nullValue + "','" + pass1 + "');");
                    com.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("submitted successfully");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }

            }
        }
    }
}
