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
    public partial class Resetpasswordform : Form
    {
        public Resetpasswordform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                SqlDataAdapter SQLAdapter = new SqlDataAdapter("select * from registration where email='" + textBox1.Text + "'", SQLConn);
                DataTable DT = new DataTable();
                SQLAdapter.Fill(DT);

                if (DT.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLAdapter = new SqlDataAdapter("update registration set password='" + textBox3.Text + "'", SQLConn);
                    SQLAdapter.Fill(DT);
                    MessageBox.Show("Successfully updated");
                    this.Hide();
                    Loginform f2 = new Loginform();
                    f2.ShowDialog();

                }

            }
        }
    }
}
