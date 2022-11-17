using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_v1
{
    internal class Login
    {
        private string username;
        private string password;

        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get { return username;} }
        public string Password { get { return password;} }
    }
}
