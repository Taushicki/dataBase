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
    public partial class userWindow : Form
    {
        private DataBaseConnection dataBase = new DataBaseConnection();
        private DataTable userData;
        private string userId;
        private string userRights;
        private ComboBox ProfileComboBoxPost = new ComboBox();
        private ComboBox ProfileComboBoxRights = new ComboBox();

        public userWindow(DataTable userData, string userID, string userRights)
        {
            InitializeComponent();
            this.userData = userData;
            this.userId = userID;
            this.userRights = userRights;
            ProfileComboBoxPost.Location = new Point(10, 150);
            ProfileComboBoxRights.Location = new Point(190, 390);

        }

        private void FillTheUserFields()
        {
            
            DataRow row = userData.Rows[0];
            ProfileFieldId.Text = userId;
            ProfileFieldName.Text = row["Name"].ToString();
            ProfileFieldSurname.Text = row["Surname"].ToString();
            ProfileFieldMiddleName.Text = row["Middle name"].ToString();
            
            ProfileFieldPassportData.Text = row["Passport data"].ToString();
            ProfileFieldItn.Text = row["ITN"].ToString();
            ProfileFieldPhoneNumber.Text = row["Phone number"].ToString();
            ProfileFieldLogin.Text = row["Login"].ToString();
            ProfileFieldPassword.Text = row["Password"].ToString();
            if (userRights != "Admin")
            {
                ProfileFieldPost.Text = row["Post"].ToString();
                ProfileFieldRights.Text = row["Rights"].ToString();
            }
            else { 
                ProfileComboBoxPost.Text = row["Post"].ToString();
                ProfileComboBoxRights.Text = row["Rights"].ToString();
            }
        }
        private void userWindow_Load(object sender, EventArgs e)
        {
            
            if (userRights == "Admin")
            {
                ProfileFieldLogin.ReadOnly = false;
                Controls.Remove(ProfileFieldPost);
                Controls.Remove(ProfileFieldRights);
                string[] posts = { "Director", "Manager", "Seller" };
                ProfileComboBoxPost.Items.AddRange(posts);
                Controls.Add(ProfileComboBoxPost);
                string[] rights = { "Admin", "User" };
                ProfileComboBoxRights.Items.AddRange(rights);
                Controls.Add(ProfileComboBoxRights);
            }
            FillTheUserFields();
        }

        private void ProfileEditButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> sellerData; 
            if (userRights != "Admin")
            {
                sellerData = new Dictionary<string, string>()
                {
                    {"Seller id", ProfileFieldId.Text},
                    {"Name", ProfileFieldName.Text},
                    {"Surname", ProfileFieldSurname.Text},
                    {"Middle name", ProfileFieldMiddleName.Text},
                    {"Post", ProfileFieldPost.Text},
                    {"Passport data", ProfileFieldPassportData.Text},
                    {"ITN", ProfileFieldItn.Text},
                    {"Phone number", ProfileFieldPhoneNumber.Text},
                    {"Login", ProfileFieldLogin.Text},
                    {"Password", ProfileFieldPassword.Text},
                    {"Rights", ProfileFieldRights.Text}
                };
            } else {
                sellerData = new Dictionary<string, string>()
                {
                    { "Seller id", ProfileFieldId.Text},
                    { "Name", ProfileFieldName.Text},
                    { "Surname", ProfileFieldSurname.Text},
                    { "Middle name", ProfileFieldMiddleName.Text},
                    { "Post", ProfileComboBoxPost.Text},
                    { "Passport data", ProfileFieldPassportData.Text},
                    { "ITN", ProfileFieldItn.Text},
                    { "Phone number", ProfileFieldPhoneNumber.Text},
                    { "Login", ProfileFieldLogin.Text},
                    { "Password", ProfileFieldPassword.Text},
                    { "Rights", ProfileComboBoxRights.Text}
                };
            }
            

            dataBase.UpdateSellersData(sellerData);
        }

        private void ProfileOkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        
    }
}
