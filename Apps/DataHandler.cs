using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Apps
{
    internal class DataHandler
    {
        int studentN;
        string Name;
        string Surname;


        string Gender;
        string DOB;
        string PhoneNum;

        string Address;
        string ModuleC;



        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;

        private string connection  ="Server =(local); Initial Catalog =BelgiumCampus; Integrated Security =SSPI";

       

        public DataHandler(int studentN, string Name, string Surname, string Gender, string DOB, string PhoneNum,string Address,string ModuleC)
        {
            
            this.studentN = studentN;
            this.Name = Name;
            this.Surname = Surname;
            this.Gender = Gender;
            this.DOB = DOB;
            this.PhoneNum = PhoneNum;
            this.Address = Address;
            this.ModuleC = ModuleC;
        }

        public DataHandler()
        {
        }

        private void openCon()
        {
            conn = new SqlConnection(connection);
            conn.Open();
        }
        public void SaveMethodModule(string ModuleCodes,string ModuleNames,string ModuleDescs,string ModuleRs)
        {
            string insertQuery = ("Insert into Modules Values ( '" + ModuleCodes + "','" + ModuleNames + "','" + ModuleDescs + "','" + ModuleRs + "','");

            DataTable l = new DataTable();
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

        public void UpdateMethodModule(string ModuleCodeu, string ModuleNameu, string ModuleDescu, string ModuleRu)
        {
            string updateQuery = ("UPDATE Modules SET[Module] = '" + ModuleCodeu + "', [ModuleName]= '" + ModuleNameu + "', [ModuleDesc]='" + ModuleDescu + "',, [ModuleResources]='" + ModuleRu + "' WHERE [StudentNumber]='" + ModuleCodeu + "' ");
           
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
        public void DeleteMethodModule(string ModuleCoded)
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
        public void SaveMethodStudent(int studentNf , string Namef, string Surnamef, string Genderf, string DOBf, string PhoneNumf, string Addressf,string ModuleCf)
        {
            
            string insertQuery = ("Insert into Student Values ( '" + studentNf + "','" + Namef + "','" + Surnamef + "','" + Genderf + "','" + DOBf + "','" + PhoneNumf+ "','" + Addressf+ "'','" + ModuleCf + "')");

            DataTable l = new DataTable();
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
            string deleteQuery = ("DELETE FROM Student WHERE ID ='" + StudentND +"'");
            openCon();
            command = new SqlCommand(deleteQuery, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("The record with the following ID number: : " + StudentND+" has been deleted");

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

        public void updateMethodStudent(int studentNu , string Nameu, string Surnameu, string Genderu, string DOBu, string PhoneNumu, string Addressu,string ModuleCu)
        {
            string updateQuery = ("UPDATE Student SET[StudentNumber] = '" + studentNu + "', [Name]= '" + Nameu +"', [Surname]='" + Surnameu + "',, [Gender]='" + Genderu + "', [DOB]='" + DOBu + "', [PhoneNumber]='" + PhoneNumu + "', [Address]='" + Addressu + "', [Module]='" + ModuleCu + "' WHERE [StudentNumber]='" + studentNu + "' ");
            //string insertQuery = ("UPDATE into Student SET ( '" + studentNf + "','" + Namef + "','" + Surnamef + "','" + Genderf + "','" + DOBf + "','" + PhoneNumf + "','" + Addressf + "'','" + ModuleCf + "')");
            openCon();

            command = new SqlCommand(updateQuery,conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Record that contains the student number:" + studentNu + " was updated");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());


            }


        }

        public void searchMethod(string IDs)
        {
            string searchQuery = ("SELECT*FROM PatientDetails WHERE ID ='" + IDs + "'");
            openCon();
            command = new SqlCommand(searchQuery, conn);

            try
            {
                reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Name=reader[1].ToString();
                    Surname= reader[2].ToString();
                    Gender= reader[3].ToString();
                    DOB= reader[4].ToString();
                    PhoneNum= reader[5].ToString();


                    MessageBox.Show("The Record for " + IDs +  "was found");   
                }
                else
                {
                    MessageBox.Show("The Record for " + IDs + " was not found");
                }

            }
            catch (SqlException err)
            {

                MessageBox.Show(err.Message);
            }
            finally {

                if (conn != null) 
                {
                    conn.Close();
                }
             reader.Close();
            }
        }


    }
}

