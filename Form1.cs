using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Number
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter: Student Number", "Warning! Student Information Incorrect");
                return;
            }
            try
            {
                int test = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter: Valid Student number", "Warning! Student Information Incorrect");
                return;
            }

            if ((textBox1.Text).Length != 6)
            {
                MessageBox.Show("Please Enter: Student Number not the correct length", "Warning! Student Information Incorrect");
            }

            //Name and Surname
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter: Name and Surname", "Warning! Student Information Incorrect");
                return;
            }
            //DOB
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please Enter: Date of Birth", "Warning! Student Information Incorrect");
                return;
            }
            //Gender
            if (textBox5.Text == "")
            {
                MessageBox.Show("Please Enter: Gender", "Warning! Student Information Incorrect");
                return;
            }
            //Number
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please Enter: Phone Number", "Warning! Student Information Incorrect");
                return;
            }
            try
            {
                int test = int.Parse(textBox6.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter: Valid Phone number", "Warning! Student Information Incorrect");
                return;
            }
            //Check if lenght right also
            if ((textBox6.Text).Length != 10)
            {
                MessageBox.Show("Please Enter: Phone Number not the correct length", "Warning! Student Information Incorrect");
            }

            //Adress
            if (textBox7.Text == "")
            {
                MessageBox.Show("Please Enter: Adress", "Warning! Student Information Incorrect");
                return;
            }

            //Module
            //Module Code
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter: Module code", "Warning! Module Information Incorrect");
                return;
            }

            if ((textBox3.Text).Length != 3)
            {
                MessageBox.Show("Please Enter: Module length not correct", "Warning! Module Information Incorrect");
            }
            //Module Name
            if (textBox9.Text == "")
            {
                MessageBox.Show("Please Enter: Module Name", "Warning! Module Information Incorrect");
                return;
            }
            //Module Code
            if (textBox10.Text == "")
            {
                MessageBox.Show("Please Enter: Module code", "Warning! Module Information Incorrect");
                return;
            }
            //Module Code
            if (textBox11.Text == "")
            {
                MessageBox.Show("Please Enter: Links to Resources", "Warning! Module Information Incorrect");
                return;
            }

            /*DataTable checkUser = new DataTable();
            checkUser = this.myDatabase.executeSqlCommand("");
            if (checkUser.Rows.Count > 0)
            {
                MessageBox.Show("The Student Number is duplicated", "Warning");
            }
            else
            {
                //Insert data into database
                this.myDatabase.executeSqlCommand("INSERT INTO");
                MessageBox.Show("The Student is saved");
                load_userAccount();
            }
             */


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

    }

}


