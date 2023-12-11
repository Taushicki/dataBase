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
        private DataTable userData;
        public string userId{ get; private set; }
        public loginWindow() 
        {
            InitializeComponent(); 
        }
        private void SignInButtonLP_Click(object sender, EventArgs e)
        {
            LabelWarningLoginFieldLP.Visible = false;
            LabelWarningPasswordFieldLP.Visible = false;

            if (string.IsNullOrWhiteSpace(LoginFieldLP.Text))
            {
                LabelWarningLoginFieldLP.Visible = true;
            }

            if (string.IsNullOrWhiteSpace(PasswordFieldLP.Text))
            {
                LabelWarningPasswordFieldLP.Visible = true;
            }

            if (!string.IsNullOrWhiteSpace(LoginFieldLP.Text) && !string.IsNullOrWhiteSpace(PasswordFieldLP.Text))
            {
                userData = dataBase.GetUserDataByLogin(LoginFieldLP.Text);

                if (userData.Rows.Count > 0)
                {
                    DataRow dataRow = userData.Rows[0];
                    string userPassword = dataRow["user_password"].ToString();

                    if (userPassword == PasswordFieldLP.Text)
                    {
                        userId = dataRow["user_id"].ToString();
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
                    LabelWarningLoginFieldLP.Visible = true;
                }
            }
        }

        private void SignUpButtonRP_Click(object sender, EventArgs e)
        {
            LabelWarningLoginFieldRP.Visible = false;
            LabelWarningPasswordFieldRP.Visible = false;
            LabelWarningConfirmPasswordFieldRP.Visible = false;

            if (string.IsNullOrWhiteSpace(LoginFieldRP.Text))
            {
                LabelWarningLoginFieldRP.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(PasswordFieldRP.Text))
            {
                LabelWarningPasswordFieldRP.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(ConfirmPasswordFieldRP.Text))
            {
                LabelWarningConfirmPasswordFieldRP.Visible = true;
            }

            if (!LabelWarningLoginFieldRP.Visible && !LabelWarningPasswordFieldRP.Visible && !LabelWarningConfirmPasswordFieldRP.Visible)
            {
                DataTable userData = dataBase.GetUserDataByLogin(LoginFieldRP.Text);

                if (userData.Rows.Count == 0)
                {
                    if (PasswordFieldRP.Text == ConfirmPasswordFieldRP.Text)
                    {
                        dataBase.AddSeller(LoginFieldRP.Text, PasswordFieldRP.Text);
                        LoginFieldRP.Clear();
                        PasswordFieldRP.Clear();
                        ConfirmPasswordFieldRP.Clear();
                        this.Controls.Clear();
                        this.Controls.Add(LoginUserPanel);
                        LoginUserPanel.Visible = true;
                    }
                    else
                    {
                        LabelWarningConfirmPasswordFieldRP.Text = "Passwords don't match";
                        LabelWarningConfirmPasswordFieldRP.Visible = true;
                    }
                }
                else
                {
                    LabelWarningLoginFieldRP.Text = "Login is unavailable";
                    LabelWarningLoginFieldRP.Visible = true;
                }
            }
        }

        private void SignUpButtonLP_Click(object sender, EventArgs e)
        {
            LoginFieldLP.Clear();
            PasswordFieldLP.Clear();
            this.Controls.Clear();
            this.Controls.Add(RegisterUserPanel);
            RegisterUserPanel.Visible = true;
        }

        private void BackButtonRP_Click(object sender, EventArgs e)
        {
            LoginFieldRP.Clear();
            PasswordFieldRP.Clear();
            ConfirmPasswordFieldRP.Clear();
            this.Controls.Clear();
            this.Controls.Add(LoginUserPanel);
            LoginUserPanel.Visible = true;
        }

    }
}
