using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBase
{
    public partial class loginWindow : Form
    {
        private string userLogin;
        private string userPassword;


        public loginWindow()
        {
            InitializeComponent();
        }

        public string getUserLogin
        {
            get{
                return userLogin;
            }
            
        }
        public string getUserPasword
        {
            get{
                return userPassword;
            }
            
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            labelWarningLoginField.Visible = false;
            labelWarningPasswordField.Visible = false;

            if (loginField.Text == "" && passwordField.Text == "")
            {
                labelWarningLoginField.Visible = true;
                labelWarningPasswordField.Visible = true;
            }
            else if(loginField.Text == "")
            {
                labelWarningLoginField.Visible=true;
            }
            else if (passwordField.Text == "")
            {
                labelWarningPasswordField.Visible = true;
            }
            else
            {
                userLogin = loginField.Text;
                userPassword = passwordField.Text;
                DialogResult = DialogResult.OK;
            } 
        }
    }
}
