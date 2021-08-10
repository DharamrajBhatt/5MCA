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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
            //fontDialog1.ShowDialog();
           // richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkboxTerms_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "unknown.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName))
                    sw.WriteLine(txt1.Text);
                    //'"\n reg No:", numericUpDown1.Value, "\n email:", txt2.Text, "\n DOB:", monthCalendar1.Handle,"\n Address:", richTextBox1.Text,"\n subject:",comboBox1.SelectedIndex,"\nQuiz Day:",dateTimePicker1.Value);
            }
        }
    }
}
