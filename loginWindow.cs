using Npgsql;
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
        private DataBaseConnection dataBase = new DataBaseConnection();
        public string userRights;
        public loginWindow() 
        {
            InitializeComponent(); 
        }
        private void SignInButtonLP_Click(object sender, EventArgs e)
        {
            LabelWarningLoginFieldLP.Visible = false;
            LabelWarningPasswordFieldLP.Visible = false;

            if (LoginFieldLP.Text == "")
                LabelWarningLoginFieldLP.Visible = true;
            if (PasswordFieldLP.Text == "")
                LabelWarningPasswordFieldLP.Visible = true;
            if(LoginFieldLP.Text != "" && PasswordFieldLP.Text != "")
            {
                DataTable userData = dataBase.GetUserDataByLogin(LoginFieldLP.Text);
                if (userData.Rows.Count > 0)
                {
                    DataRow dataRow = userData.Rows[0];
                    if(dataRow["user_password"].ToString() == PasswordFieldLP.Text)
                    {
                        userRights = dataRow["user_rights"].ToString();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        LabelWarningPasswordFieldLP.Text = "Invalid password";
                        LabelWarningPasswordFieldLP.Visible = true;
                    }
                }
                else
                {
                    LabelWarningLoginFieldLP.Text = "User not found";
                    LabelWarningLoginFieldLP.Visible=true;
                }
            } 
        }

        private void SignUpButtonLP_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(RegisterUserPanel);
            RegisterUserPanel.Visible = true;  
        }

        private void SignUpButtonRP_Click(object sender, EventArgs e)
        {
            LabelWarningLoginFieldRP.Visible = false;
            LabelWarningPasswordFieldRP.Visible = false;
            LabelWarningConfirmPasswordFieldRP.Visible = false;

            if (LoginFieldRP.Text == "")
                LabelWarningLoginFieldRP.Visible = true;
            if (PasswordFieldRP.Text == "")
                LabelWarningPasswordFieldRP.Visible = true;
            if (ConfirmPasswordFieldRP.Text == "")
                LabelWarningConfirmPasswordFieldRP.Visible = true;
            if(LoginFieldRP.Text != "" && PasswordFieldRP.Text != "" && ConfirmPasswordFieldRP.Text != "")
            {
                DataTable userData = dataBase.GetUserDataByLogin(LoginFieldLP.Text);
                if (userData.Rows.Count == 0)
                {
                    if (PasswordFieldRP.Text == ConfirmPasswordFieldRP.Text)
                    {
                        dataBase.AddUser(LoginFieldRP.Text, PasswordFieldRP.Text);
                        this.Controls.Clear();
                        this.Controls.Add(LoginUserPanel);
                        LoginUserPanel.Visible = true;
                    }
                    else
                    {
                        LabelWarningConfirmPasswordFieldRP.Text = "passwords don't match";
                        LabelWarningConfirmPasswordFieldRP.Visible= true;
                    }
                }
                else
                {
                    LabelWarningLoginFieldRP.Text = "Login is unavailable";
                    LabelWarningLoginFieldRP.Visible = true;
                }
            }
        }
    }
}
