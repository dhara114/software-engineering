using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureProject;

namespace LoginAndRegistration
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            //DataSet datasetUser = dbConn.getDataSet("SELECT * FROM User");

            string FirstName = FirstNameText.Text;
            string LastName = LastNameText.Text;
            int PhoneNumber = Convert.ToInt32(PhoneNumText.Text);
            string Email = EmailText.Text;
            string Address = AddressText.Text;
            string TownCity = TownCityText.Text;
            string Postcode = PostcodeText.Text;
            string Password = PasswordText.Text;
            string ConfirmPassword = ConfirmPasswordText.Text;
            dbConn.saveToDB("INSERT INTO [User] (FirstName, LastName, PhoneNumber, Email, Address, TownCity, Postcode, Password)" +
                "VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address, @TownCity, @Postcode, @Password)",
                FirstName, LastName, PhoneNumber, Email, Address, TownCity, Postcode, Password);
        } 

        private void ShowPasswordChkbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TownCityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailListSub_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
