using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentRegistrationApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayInfo(string fullname, string gender, string dob, string program)
        {
           

            string message = "Student Name: " + fullname + "\nGender: " 
                + gender + "\nDate of Birth: " + dob + "\nProgram: " + program;
            
            MessageBox.Show(message);
            
        }
        private void DisplayInfo(string fullname, string program)
        {
            string message = "Student Name: " + fullname + "\nProgram: " + program;
            MessageBox.Show(message);
        }
        private void DisplayInfo(string firstname, string lastname, string program) {
            
           string message = "Student Name: " + firstname + " " + lastname + "\nProgram: " + program;
            MessageBox.Show(message);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String lname = tblname.Text;
            String fname = tbfname.Text;
            String mname = tbmname.Text;
            String gender = "";

            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfmale.Checked)
            {
                gender = "Female";
            }
            if (cbday.SelectedIndex == -1 || cbmonth.SelectedIndex == -1 || cbyear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your date of birth");
                MessageBoxButtons button = MessageBoxButtons.OK;
                return;
            }
            int day = (int)cbday.SelectedItem - 1;
            int month = cbmonth.SelectedIndex - 1;
            int Year = (int)cbyear.SelectedItem;
            String program = cbprogram.Text;

            DateTime dateTime = new DateTime(Year, month, day);
            
            string dob = dateTime.ToString("MMMM dd, yyyy");
            string fullname = fname + " " + mname + " " + lname + "";
           

            DisplayInfo(fullname, gender , dob, program);
            DisplayInfo(fullname, program);
            DisplayInfo(fname, lname, program);

            if (lname == "" || fname == "" || mname == "")
            {
                MessageBox.Show("Please fill in all the fields");
                MessageBoxButtons button = MessageBoxButtons.OK;
                return;
            }
            else if (!rbmale.Checked && !rbfmale.Checked)
            {

                MessageBox.Show("Please select your gender ");
                MessageBoxButtons button = MessageBoxButtons.OK;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                cbday.Items.Add(i);


            }
            String[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december"};
            

            cbmonth.Items.AddRange(months);
            String[] programs = { "Bachelor of Science in Computer Science",
                    "Bachelor of Science in Information Technology",
                    "Bachelor of Science in Information Systems",
                    "Bachelor of Science in Computer Engineering" };
            cbprogram.Items.AddRange(programs);
            


           int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= 1900; i--)
            {
                cbyear.Items.Add(i);
            }
        }

        private void cbyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
