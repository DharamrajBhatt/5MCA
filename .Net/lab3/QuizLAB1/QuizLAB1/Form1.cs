using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizLAB1
{
    public partial class registrationform : Form
    {
        public registrationform()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://thebridge.in/terms-and-conditions/quiz");
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String gender;
            String pass1 = textBox1.Text;
            String pass2 = textBox2.Text;
            String name = txt1.Text;
            String email = txt2.Text;
            if (txt1.Text == string.Empty)
            {
                MessageBox.Show("Name can't be Empty");
                txt1.Focus();
                return;
            }
            else if (!Regex.Match(txt1.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // name was incorrect  
                MessageBox.Show("Invalid name");
                txt1.Focus();
                return;
            }
            else if (txt2.Text == string.Empty)
            {
                MessageBox.Show("Email can't be Empty");
                return;
            }
            
            else if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                MessageBox.Show("atlest one gender should be choosed!");
                return;
            }
           
            else if (checkboxTerms.Checked != true)
            {
                MessageBox.Show("Please accept the terms and condition.!");
                return;
            }
            else if (pass.Text == string.Empty)
            {
                MessageBox.Show("password can't be Empty");
                txt1.Focus();
                return;
            }
            else if (confpass.Text == string.Empty)
            {
                MessageBox.Show("confirm password can't be Empty");
                txt1.Focus();
                return;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked)
                {
                    gender = "Female";

                }
                else
                {
                    gender = "Others";
                }

                if (!pass1.Equals(pass2))
                {
                    MessageBox.Show("Password doesn't match", "please ReEnter passwords again");
                }
                else
                {
                   


                    SqlConnection cnn = new SqlConnection();
                    SqlCommand com = new SqlCommand();
                    cnn.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dharamraj bhatt\Source\Repos\QuizLAB1\QuizLAB1\quiz.mdf;Integrated Security=True");
                    cnn.Open();
                    com.Connection = cnn;
                    com.CommandText = ("INSERT INTO registration (name,email,gender,password) VALUES ('" + name + "','" + email + "','" + gender + "','" + pass1 + "');");
                    com.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("submitted successfully");
                    this.Hide();
                    Loginform f2 = new Loginform();
                    f2.ShowDialog();
                }
               
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    /*    private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
            }

        }
*/

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkboxTerms_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Loginform f2 = new Loginform();
            f2.ShowDialog();
        }
    }
}
