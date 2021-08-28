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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            String pass1 = textBox2.Text;
            String pass2 = textBox3.Text;

            if (!pass1.Equals(pass2))
            {
                MessageBox.Show("Password doesn't match", "please ReEnter passwords again");
            }
            else
            {
                SqlConnection SQLConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dharamraj bhatt\Source\Repos\QuizLAB1\QuizLAB1\quiz.mdf;Integrated Security=True");
                SqlDataAdapter SQLAdapter = new SqlDataAdapter("select * from registration_1947216 where email='" + textBox1.Text + "'", SQLConn);
                DataTable DT = new DataTable();
                SQLAdapter.Fill(DT);

                if (DT.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLAdapter = new SqlDataAdapter("update registration_1947216 set password='" + textBox3.Text + "'where email='" + textBox1.Text + "'", SQLConn);
                    SQLAdapter.Fill(DT);
                    MessageBox.Show("Successfully updated");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();

                }

            }
        }
    }
}
