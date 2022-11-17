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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            LoginHandler handler = new LoginHandler();

            try
            {
                string username = txtSignUsername.Text;
                string password = txtSignPassword.Text;
                handler.SignUp(username, password);
                MessageBox.Show("Successfully signed up " + username);

                this.Hide();
                frmLogin loginForm = new frmLogin();
                loginForm.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
