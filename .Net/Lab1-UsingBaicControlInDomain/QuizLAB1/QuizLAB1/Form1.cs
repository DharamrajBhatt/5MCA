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

namespace QuizLAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "--select--";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://thebridge.in/terms-and-conditions/quiz");
        }


        private void ValidateEmail()
        {
            string email = txt2.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                MessageBox.Show("Mail id is invalid");
                txt2.Focus();

            }
            else
            {
                MessageBox.Show("Mail id is invalid");
                txt2.Focus();
                
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txt1.Text == string.Empty)
            {
                MessageBox.Show("Name can't be Empty");
                txt1.Focus();
                return;
            }
            else if (!Regex.Match(txt1.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect  
                MessageBox.Show("Invalid first name");
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
            else if (!(radioButton4.Checked || radioButton5.Checked || radioButton6.Checked))
            {
                MessageBox.Show("atlest one difficultu level should be choosed!");
                return;
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("select atleast one subject!");
                return;
            }
            else if (checkboxTerms.Checked != true)
            {
                MessageBox.Show("Please accept the terms and condition.!");
                return;
            }
            else
            {
                MessageBox.Show("submitted successfully");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
