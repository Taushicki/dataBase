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
        private string enteredLogin;
        private string enteredPassword;
        private String connection = String.Format("Server={0};Port={1};" +
            "User id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "password", "users");
        private NpgsqlConnection conn;
        private String sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public loginWindow()
        {
            InitializeComponent();
        }
        private String getPasswordFromDB(String login, String password)
        {
            try
            {
                conn.Open();
                sql = @"select login from users where login like '" + login + "' and password like '" + password + "';";
                cmd = new NpgsqlCommand(sql, conn);
                String show = cmd.ExecuteScalar().ToString();
                MessageBox.Show(show);
                conn.Close();
                return show;
                
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
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
                conn = new NpgsqlConnection(connection);
                getPasswordFromDB(loginField.Text, passwordField.Text);
                //MessageBox.Show(loginField.Text + "\n" + passwordField.Text);
                DialogResult = DialogResult.OK;
            } 
        }
    }
}
