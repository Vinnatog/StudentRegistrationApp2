using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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
            int day = (int)cbday.SelectedItem;
            int month = cbmonth.SelectedIndex + 1;
            int Year = (int)cbyear.SelectedItem;
            String program = cbprogram.Text;

            DateTime dateTime = new DateTime(Year, month, day);
            



            MessageBox.Show("Student name: " + fname + " " + mname + " " + lname + "\n" + "Gender: " + gender + "\n" + "Date of Birth: " + dateTime.ToString("dd/MM/yyyy") + "\n"+ "Program: " + program);
            MessageBoxButtons button1 = MessageBoxButtons.OK;
           

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
            


            for (int y = 1940; y <= DateTime.Now.Year; y++)
            {
                cbyear.Items.Add(y);
                cbday.SelectedIndex = 0;
                cbmonth.SelectedIndex = 0;
                cbyear.SelectedIndex = 0;
                cbprogram.SelectedIndex = 0;
            }
        }

        private void tblname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbmname_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbfmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbday_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
