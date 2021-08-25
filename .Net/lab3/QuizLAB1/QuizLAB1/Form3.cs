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


namespace QuizLAB1
{
    public partial class Loginform : Form
    {

       
        public Loginform()
        {
            InitializeComponent();

            //db.Connect("quiz");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registrationform f3 = new registrationform();
            f3.ShowDialog();
        }

        private void logIn_Click(object sender, EventArgs e)
        {


             SqlConnection cn = new SqlConnection();
             SqlCommand cmd = new SqlCommand();
            /*
             cnn.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dharamraj bhatt\Source\Repos\QuizLAB1\QuizLAB1\quiz.mdf;Integrated Security=True");
             cnn.Open();
             com.Connection = cnn;
             com.CommandText = ("SELECT* FROM `registration` where email = '" + textBox1.Text+ "' and password = '" + textBox2.Text+"'");


             if (com.CommandText == 1)
             {
                 MessageBox.Show("Successfully logged in");

                 this.Hide();
                 quizform f3 = new quizform();
                 f3.ShowDialog();

             }
             else
             {
                 MessageBox.Show("Wrong username and password combination");
             }

             com.ExecuteNonQuery();
             cnn.Close();*/
            
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dharamraj bhatt\Source\Repos\QuizLAB1\QuizLAB1\quiz.mdf;Integrated Security=True");
            SqlDataReader dr = null;
            cn.Open();
            /*SqlDataReader dr = cmd.ExecuteReader();*/

            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from registration where email='" + textBox1.Text + "' and password='" + textBox2.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Successfully logged in");

                    this.Hide();
                    quizform f3 = new quizform();
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
            Resetpasswordform f3 = new Resetpasswordform();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dharamraj bhatt\Source\Repos\QuizLAB1\QuizLAB1\quiz.mdf;Integrated Security=True");
            SqlDataReader dr = null;
            cn.Open();
            /*SqlDataReader dr = cmd.ExecuteReader();*/

            if (textBox1.Text != string.Empty)
            {

                cmd = new SqlCommand("Delete from registration where email='" + textBox1.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Successfully Deleted");

                    this.Hide();
                    quizform f3 = new quizform();
                    f3.ShowDialog();
                }

                else
                {
                    dr.Close();
                    MessageBox.Show("Successfully Deleted");
                    //MessageBox.Show("No Account avilable with this username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter email id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
