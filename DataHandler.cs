using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace PRG282_Project_v1
{
    internal class DataHandler
    {
        private SqlConnection conn;
        private SqlCommand command;

        private string connection = @"Data Source=ANDREWS-LAPTOP\SQLEXPRESS;Initial Catalog=BelgiumCampus;Integrated Security=True";

        public DataHandler()
        {
        }

        private void openCon()
        {
            conn = new SqlConnection(connection);
            conn.Open();
        }
        public void SaveMethodModule(int ModuleCodes, string ModuleNames, string ModuleDescs, string ModuleRs)
        {
            string insertQuery = ("Insert into Modules Values ( '" + ModuleCodes + "','" + ModuleNames + "','" + ModuleDescs + "','" + ModuleRs + "'");

            openCon();
            command = new SqlCommand(insertQuery, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data has been added to the Database");

            }
            catch (SqlException err)
            {
                MessageBox.Show("An unknown error occured.");
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateMethodModule(int ModuleCodeu, string ModuleNameu, string ModuleDescu, string ModuleRu)
        {
            string updateQuery = ("UPDATE Modules SET [ModuleName]= '" + ModuleNameu + "', [ModuleDesc]='" + ModuleDescu + "',, [ModuleResources]='" + ModuleRu + "' WHERE [Module] = '" + ModuleCodeu + "'");

            openCon();

            command = new SqlCommand(updateQuery, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Record that contains the Module Code:" + ModuleCodeu + " was updated");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());


            }
        }
        public void DeleteMethodModule(int ModuleCoded)
        {
            string deleteQuery = ("DELETE FROM Modules WHERE Module ='" + ModuleCoded + "'");
            openCon();
            command = new SqlCommand(deleteQuery, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("The record with the following Module Code: : " + ModuleCoded + " has been deleted");

            }
            catch (SqlException err)
            {
                MessageBox.Show("An unkown error occured");
                MessageBox.Show(err.ToString());
            }
        }
        public void SaveMethodStudent(int studentNf, string Namef, string Surnamef, string Genderf, DateTime DOBf, string PhoneNumf, string Addressf, int ModuleCode)
        {

            string insertQuery = ("Insert into Students Values ( '" + studentNf + "','" + Namef + "','" + Surnamef + "','" + Genderf + "','" + DOBf + "','" + PhoneNumf + "','" + Addressf + "'','" + ModuleCode + "')");

            openCon();
            command = new SqlCommand(insertQuery, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data has been added to the Database");

            }
            catch (SqlException err)
            {
                MessageBox.Show("An unknown error occured.");
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
        public void deleteMethodStudent(int StudentND)
        {
            string deleteQuery = ("DELETE FROM Students WHERE ID ='" + StudentND + "'");
            openCon();
            command = new SqlCommand(deleteQuery, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("The record with the following ID number: : " + StudentND + " has been deleted");

            }
            catch (SqlException err)
            {
                MessageBox.Show("An unkown error occured");
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

        public void updateMethodStudent(int studentNf, string Namef, string Surnamef, string Genderf, DateTime DOBf, string PhoneNumf, string Addressf, int ModuleCode)
        {
            string updateQuery = ("UPDATE Students SET [Name]= '" + Namef + "', [Surname]='" + Surnamef + "',, [Gender]='" + Genderf + "', [DOB]='" + DOBf + "', [PhoneNumber]='" + PhoneNumf + "', [Address]='" + Addressf + "', [ModuleCode]='" + ModuleCode + "' WHERE [StudentNumber]='" + studentNf + "' ");
 
            openCon();

            command = new SqlCommand(updateQuery, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Record that contains the student number:" + studentNf + " was updated");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public DataTable searchMethodNew(int IDs)
        {
            string searchQuery = ("SELECT*FROM Students WHERE ID ='" + IDs + "'");

            conn = new SqlConnection(connection);

            SqlDataAdapter da = new SqlDataAdapter(searchQuery, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataTable searchMethodModule(int IDs)
        {
            string searchQuery = ("SELECT*FROM Modules WHERE ID ='" + IDs + "'");

            conn = new SqlConnection(connection);

            SqlDataAdapter da = new SqlDataAdapter(searchQuery, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
