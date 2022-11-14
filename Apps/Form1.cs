﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Form1 : Form
    {
     DataHandler data = new DataHandler();     
     public static  SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;


        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Server =(local); Initial Catalog =BelgiumCampus; Integrated Security =SSPI") ; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Start up");
            try
            {
                connection.Open();
                MessageBox.Show("The Connection is now open");

                command = new SqlCommand("select*from Student", connection);

                SqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("select*from Student", connection);

                SqlDataReader reader;
                reader = command.ExecuteReader();

                BindingSource source = new BindingSource();
                source.DataSource = reader;

                dataGridView1.DataSource = source;
            }
            catch(SqlException error) {
                 MessageBox.Show(error.ToString());
            }
            finally
            { if(connection!= null)
                {
                    connection.Close();
                } 
                
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBoxStudentN.Text =="")
            {
                MessageBox.Show("Please enter the Student Number that you want to delete");
            }
            else
            {
                data.deleteMethodStudent(Int16.Parse(textBoxStudentN.Text));
            }
  
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
           //textBoxStudentN.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update

            //ID Number
            if (textBoxStudentN.Text == "")
            {
                MessageBox.Show("Please Enter: Student Number", "Warning");
                return;
            }
            try
            {
                int test = int.Parse(textBoxStudentN.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a valid Student Number", "Warning");
                return;
            }


            if ((textBoxStudentN.Text).Length != 6)
            {
                MessageBox.Show("Please Enter: Student Number not the correct length", "Warning!");
            }

            //Name and Surname
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please Enter: Name", "Warning!");
                return;
            }

            if (textBoxSurname.Text == "")
            {
                MessageBox.Show("Please Enter: Surname", "Warning!");
                return;
            }

            //Gender
            if (textBoxGender.Text == "")
            {
                MessageBox.Show("Please Enter: Gender", "Warning!");
                return;
            }

            //DOB
            if (textBoxDOB.Text == "")
            {
                MessageBox.Show("Please Enter: Date of Birth", "Warning!");
                return;
            }

            //Phone Number
            if (textBoxPNum.Text == "")
            {
                MessageBox.Show("Please Enter: Phone Number", "Warning!");
                return;
            }

            if ((textBoxPNum.Text).Length != 10)
            {
                MessageBox.Show("Please Enter: Phone Number not the correct length", "Warning!");
            }

            //Address

            if (textBoxAddress.Text == "")
            {
                MessageBox.Show("Please Enter: Address", "Warning!");
                return;
            }

            //Module

            if (textBoxModuleC.Text == "")
            {
                MessageBox.Show("Please Enter: Module", "Warning!");
                return;
            }

            if ((textBoxModuleC.Text).Length != 6)
            {
                MessageBox.Show("Please Enter: Module Code not the correct length", "Warning!");
            }


            //update   
            data.updateMethodStudent(Int16.Parse(textBoxStudentN.Text), textBoxName.Text, textBoxSurname.Text, textBoxGender.Text, textBoxDOB.Text, textBoxPNum.Text, textBoxAddress.Text,textBoxPNum.Text);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

            if(textBoxStudentN.Text !="")
            {
                data.searchMethod(textBoxStudentN.Text);
            }
            else
            {
                MessageBox.Show("Please enter the Student Number");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ID Number
            if (textBoxStudentN.Text == "")
            {
                MessageBox.Show("Please Enter: Student Number", "Warning");
                return;
            }
            try
            {
                int test = int.Parse(textBoxStudentN.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a valid Student Number", "Warning");
                return;
            }


            if ((textBoxStudentN.Text).Length != 6)
            {
                MessageBox.Show("Please Enter: Student Number not the correct length", "Warning!");
            }

            //Name and Surname
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please Enter: Name", "Warning!");
                return;
            }

            if (textBoxSurname.Text == "")
            {
                MessageBox.Show("Please Enter: Surname", "Warning!");
                return;
            }

            //Gender
            if (textBoxGender.Text == "")
            {
                MessageBox.Show("Please Enter: Gender", "Warning!");
                return;
            }

            //DOB
            if (textBoxDOB.Text == "")
            {
                MessageBox.Show("Please Enter: Date of Birth", "Warning!");
                return;
            }

            //Phone Number
            if (textBoxPNum.Text == "")
            {
                MessageBox.Show("Please Enter: Phone Number", "Warning!");
                return;
            }

            if ((textBoxPNum.Text).Length != 10)
            {
                MessageBox.Show("Please Enter: Phone Number not the correct length", "Warning!");
            }

            //Address

            if (textBoxAddress.Text == "")
            {
                MessageBox.Show("Please Enter: Address", "Warning!");
                return;
            }

            //Module

            if (textBoxModuleC.Text == "")
            {
                MessageBox.Show("Please Enter: Module", "Warning!");
                return;
            }
            /*try
            {
                int test = int.Parse(textBoxModuleC.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter:Valid Module Code", "Warning!");
                return;
            }*/

            if ((textBoxModuleC.Text).Length != 6)
            {
                MessageBox.Show("Please Enter: Module Code not the correct length", "Warning!");
            }



            //Read data into method
            data.SaveMethodStudent(Int16.Parse(textBoxStudentN.Text), textBoxName.Text, textBoxSurname.Text, textBoxGender.Text, textBoxDOB.Text, textBoxPNum.Text, textBoxAddress.Text,textBoxPNum.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxStudentN.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxGender.Clear();  
            textBoxDOB.Clear();
            textBoxPNum.Clear();
            textBoxAddress.Clear();
            textBoxAddress.Clear();
            textBoxModuleC.Clear();
        }
    }
}