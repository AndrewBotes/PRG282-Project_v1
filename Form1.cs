using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_v1
{
    public partial class Form1 : Form
    {

        DataHandler data = new DataHandler();
        public static SqlConnection connection = new SqlConnection(@"Data Source=ANDREWS-LAPTOP\\SQLEXPRESS;Initial Catalog=BelgiumCampus;Integrated Security=True");
        SqlCommand command;

        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime dob = new DateTime();
                dob = dtpDob.Value;
                data.SaveMethodStudent(Int32.Parse(textBoxStudentN.Text), textBoxName.Text, textBoxSurname.Text, textBoxGender.Text, dob, textBoxPNum.Text, textBoxAddress.Text, Int32.Parse(textBoxModuleC.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //update   
                DateTime dob = new DateTime();
                dob = dtpDob.Value;
                data.updateMethodStudent(Int32.Parse(textBoxStudentN.Text), textBoxName.Text, textBoxSurname.Text, textBoxGender.Text, dob, textBoxPNum.Text, textBoxAddress.Text, Int32.Parse(textBoxModuleC.Text));
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                data.deleteMethodStudent(Int32.Parse(textBoxStudentN.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("select*from Students", connection);

                SqlDataReader reader;
                reader = command.ExecuteReader();

                BindingSource source = new BindingSource();
                source.DataSource = reader;

                dataGridView1.DataSource = source;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxStudentN.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxGender.Clear();
            textBoxPNum.Clear();
            textBoxAddress.Clear();
            textBoxAddress.Clear();
            textBoxModuleC.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchVal = Int32.Parse(txtStudentSearch.Text);
                dataGridView1.DataSource = data.searchMethodNew(searchVal);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 moduleForm = new Form4();
            moduleForm.ShowDialog();
            this.Close();
        }
    }
}
