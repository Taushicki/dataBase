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
        private readonly string connection = string.Format("Server={0};Port={1};" +
            "User id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "password", "mobiledevicestore");

        private string sql;

        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;

        public loginWindow()
        {
            InitializeComponent();
        }

        private bool FindUserFromDB(string login)
        {
            try {
                conn.Open();
                sql = @"select 1 from users where login = '" + login + "';";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteScalar().ToString();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
            
        }
        private bool CheckUserPasswordFromDB(string login)
        {
            try
            {
                conn.Open();
                sql = @"select password from users where login = '" + login + "';";
                cmd = new NpgsqlCommand(sql, conn);
                if (cmd.ExecuteScalar().ToString() == passwordField.Text)
                {
                    conn.Close();
                    return true;
                }
                else
                { 
                    conn.Close();
                    return false;
                }
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            labelWarningLoginField.Visible = false;
            labelWarningPasswordField.Visible = false;

            if (loginField.Text == "" && passwordField.Text == "")
            {
                labelWarningLoginField.Visible = true;
                labelWarningPasswordField.Visible = true;
            }
            else if(loginField.Text == "")
                labelWarningLoginField.Visible=true;

            else if (passwordField.Text == "")
                labelWarningPasswordField.Visible = true;

            else
            {
                conn = new NpgsqlConnection(connection);
                if (FindUserFromDB(loginField.Text))
                {
                    if (CheckUserPasswordFromDB(loginField.Text))
                        DialogResult = DialogResult.OK;
                    else 
                    {
                        labelWarningPasswordField.Text = "Invalid password";
                        labelWarningPasswordField.Visible = true;
                    }
                }
                else
                {
                    labelWarningLoginField.Text = "User not found";
                    labelWarningLoginField.Visible=true;
                }
            } 
        }
    }
}
