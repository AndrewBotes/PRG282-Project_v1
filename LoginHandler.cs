using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_v1
{
    internal class LoginHandler
    {
        public LoginHandler() { }

        
        List<Login> users = new List<Login>();

        //Automatically gets the path to the txt file
        private const string V = @"\users.txt";
        static string path = new DirectoryInfo(Directory.GetCurrentDirectory()) + V;
     
        //Add a new user to users.txt file
        public void SignUp(string username, string password) 
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                Login user = new Login(username, password);
                users.Add(user);

                sw.WriteLine(user.Username + "," + user.Password);
            }
        }

        //Goes through the text file and returns true or false if a user is found or not
        public bool Login(string username, string password)
        {
            List<Login> existingUsers = new List<Login>();
            if(File.Exists(path))
            {
                using(StreamReader sr = new StreamReader(path)) 
                {
                    string[] user = sr.ReadLine().Split(',');
                    Login registeredUser = new Login(user[0], user[1]);
                    existingUsers.Add(registeredUser);
                }        
            }

            if(existingUsers[existingUsers.Count - 1].Username == username && existingUsers[existingUsers.Count - 1].Password == password) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
