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
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {   
            
            loginWindow loginWindow = new loginWindow();
            //loginWindow.Show();
            DialogResult result = loginWindow.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show(loginWindow.getUserLogin + "\n" + loginWindow.getUserPasword);

            }
            if (result == DialogResult.Cancel)
            {
                Close();
            }
        }
    }
}
