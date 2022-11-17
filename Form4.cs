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
        private static string conn = @"Data Source=ANDREWS-LAPTOP\SQLEXPRESS;Initial Catalog=ZONE15;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(conn);
        SqlCommand command;
        SqlDataReader reader;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxModuleCode.Text == "")
            {
                MessageBox.Show("Please Enter: Module", "Warning!");
                return;
            }
            /*try
            {
                int test = int.Parse(textBoxModuleCode.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter:Valid Module Code", "Warning!");
                return;
            }*/

            if ((textBoxModuleCode.Text).Length != 6)
            {
                MessageBox.Show("Please Enter: Module Code not the correct length", "Warning!");
            }

            if ((textBoxModuleN.Text) == "")
            {
                MessageBox.Show("Please Enter: Module Name", "Warning!");
            }

            if ((textBoxModuleDesc.Text) == "")
            {
                MessageBox.Show("Please Enter: Module Description", "Warning!");
            }

            if ((textBoxModuleR.Text) == "")
            {
                MessageBox.Show("Please Enter: Links to resources", "Warning!");
            }

            //Send Data
            data.SaveMethodModule(textBoxModuleCode.Text, textBoxModuleN.Text, textBoxModuleDesc.Text, textBoxModuleR.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //data.updateMethodStudent();

            if (textBoxModuleCode.Text == "")
            {
                MessageBox.Show("Please Enter: Module", "Warning!");
                return;
            }
            try
            {
                int test = int.Parse(textBoxModuleCode.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter:Valid Module Code", "Warning!");
                return;
            }

            if ((textBoxModuleCode.Text).Length != 6)
            {
                MessageBox.Show("Please Enter: Module Code not the correct length", "Warning!");
            }

            if ((textBoxModuleN.Text) == "")
            {
                MessageBox.Show("Please Enter: Module Name", "Warning!");
            }

            if ((textBoxModuleDesc.Text) == "")
            {
                MessageBox.Show("Please Enter: Module Description", "Warning!");
            }

            if ((textBoxModuleR.Text) == "")
            {
                MessageBox.Show("Please Enter: Links to resources", "Warning!");
            }

            //Send Data
            data.UpdateMethodModule(textBoxModuleCode.Text, textBoxModuleN.Text, textBoxModuleDesc.Text, textBoxModuleR.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBoxModuleCode.Text == "")
            {
                MessageBox.Show("Please enter the Module Code that you want to delete");
            }
            else
            {
                data.DeleteMethodModule(textBoxModuleCode.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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
                connection.Open();
                MessageBox.Show("The Connection is now open");

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
