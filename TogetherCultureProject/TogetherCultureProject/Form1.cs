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
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection(); //connect to db
            DataSet datasetUser = dbConn.getDataSet(Constant.SELECTALLUser);

            //variables holding text box values
            string FirstName = FirstNameText.Text;
            string LastName = LastNameText.Text;
            string PhoneNumberInitial = (PhoneNumText.Text); //phonenum stored here initially to check for non-number values
            int PhoneNumber;
            string Email = EmailText.Text;
            string Address = AddressText.Text;
            string TownCity = TownCityText.Text;
            string Postcode = PostcodeText.Text;
            string Password = PasswordText.Text;
            string ConfirmPassword = ConfirmPasswordText.Text;
            if (FirstName.Any(Char.IsDigit) || LastName.Any(Char.IsDigit)) //checks for numbers in name variables
            {
                MessageBox.Show("Name field(s) contain an invalid value, numbers cannot be used");
            }
            else if (PhoneNumberInitial.All(Char.IsDigit)) //checks if entire string is numbers
            {
                PhoneNumber = Convert.ToInt32(PhoneNumberInitial); //phonenum string passed to int variable
                if (Password != ConfirmPassword) //password confirmation validations
                {
                    MessageBox.Show("Passwords do not match, enter matching passwords in both password fields");
                }
                else
                {
                    //insert text box values into db
                    dbConn.saveToDB(Constant.INSERTALLUser, FirstName, LastName, PhoneNumber, Email, Address, TownCity, Postcode, Password);
                }
            }
            else
            {
                MessageBox.Show("Phone number field contains an invalid value, only numbers must be entered in the phone number field");
            }
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
