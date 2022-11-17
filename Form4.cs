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
    public partial class Form4 : Form
    {

        DataHandler data = new DataHandler();
        private static string conn = @"Data Source=ANDREWS-LAPTOP\SQLEXPRESS;Initial Catalog=BelgiumCampus;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(conn);
        SqlCommand command;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                //Send Data
                data.SaveMethodModule(Int32.Parse(textBoxModuleCode.Text), textBoxModuleN.Text, textBoxModuleDesc.Text, textBoxModuleR.Text);
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
                //Send Data
                data.UpdateMethodModule(Int32.Parse(txtSearchM.Text), textBoxModuleN.Text, textBoxModuleDesc.Text, textBoxModuleR.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBoxModuleCode.Text == "")
            {
                MessageBox.Show("Please enter the Module Code that you want to delete");
            }
            else
            {
                data.DeleteMethodModule(Int32.Parse(txtSearchM.Text));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.searchMethodModule(Int32.Parse(txtSearchM.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxModuleCode.Clear();
            textBoxModuleDesc.Clear();
            textBoxModuleN.Clear();
            textBoxModuleR.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("select*from Modules", connection);

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

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select*from Modules", connection);

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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 studentForm = new Form1();
            studentForm.ShowDialog();
            this.Close();
        }
    }
}
