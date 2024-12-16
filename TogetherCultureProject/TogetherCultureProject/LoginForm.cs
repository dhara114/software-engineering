using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureProject;

namespace LoginAndRegistration
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RegForm = new RegForm();
            RegForm.Closed += (s, args) => this.Close();
            RegForm.Show();
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection(); //connect to db

            string Email = EmailText.Text;
            string Password = PasswordText.Text;
            //selects row containing email and Password columns with matching data
            DataSet datasetUser = dbConn.getDataSet("SELECT * FROM [User] WHERE Email = '" + Email + 
                "' AND Password = '" + Password + "'");

            if (datasetUser.Tables[0].Rows.Count == 0) //if no rows found = no matching data = output error message
            {
                MessageBox.Show("Incorrect email or password has been entered, please enter a valid email and password");
            }
            else //rows found, move to main screen, generic "login successful" screen in this case
            {
                this.Hide();
                var LogInSuccessful = new LogInSuccessful();
                LogInSuccessful.Closed += (s, args) => this.Close();
                LogInSuccessful.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
