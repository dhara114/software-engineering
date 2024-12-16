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
            this.Hide();
            var LoginForm = new LoginForm();
            LoginForm.Closed += (s, args) => this.Close();
            LoginForm.Show();
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
        //goes through data validation and registration process when clicked
        private void RegButton_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection(); //connect to db

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
            if((FirstName.Length == 0) || (LastName.Length == 0) || (PhoneNumberInitial.Length == 0) || (Email.Length == 0) ||
                (Address.Length == 0) || (TownCity.Length == 0) || (Postcode.Length == 0) || (Password.Length == 0) ||
                (ConfirmPassword.Length == 0)) //checks for blank fields
            {
                MessageBox.Show("Required fields are empty, please make sure all fields are filled");
            }
            else if ((FirstName.Length > 50) || (LastName.Length > 50) || (Email.Length > 50) ||
                (Address.Length > 50) || (TownCity.Length > 50) || (Password.Length > 50) || (ConfirmPassword.Length > 50)) //length validation
            {
                MessageBox.Show("An entered field contains more than 50 characters, entered data does not allow more than 50 characters");
            }
            else if (PhoneNumberInitial.Length > 11) //phone number length validation
            {
                MessageBox.Show("Phone number cannot be more than 11 digits");
            }
            else if (Postcode.Length != 7) //postcode length validation
            {
                MessageBox.Show("Incorrect postcode format used, postcode must be 7 characters with no space");
            }
            else if (FirstName.Any(Char.IsDigit) || LastName.Any(Char.IsDigit)) //checks for numbers in name variables
            {
                MessageBox.Show("Name field(s) contain an invalid value, numbers cannot be used");
            }
            else if (TownCity.Any(Char.IsDigit)) //checks for numbers in TownCity variable
            {
                MessageBox.Show("Town/City field contains an invalid value, numbers cannot be used");
            }
            else if (Constant.IsValidEmail(Email) is false)
            {
                MessageBox.Show("Email entered is using an invalid format");
            }
            else if (PhoneNumberInitial.All(Char.IsDigit)) //checks if entire string is numbers
            {
                PhoneNumber = Convert.ToInt32(PhoneNumberInitial); //phonenum string passed to int variable
                if (Password != ConfirmPassword) //password confirmation validation
                {
                    MessageBox.Show("Passwords do not match, enter matching passwords in both password fields");
                }
                else
                {
                    //insert text box values into db
                    dbConn.saveToDB(Constant.INSERTALLUser, FirstName, LastName, PhoneNumber, Email, Address, TownCity, Postcode, Password);
                    //return to login page
                    this.Hide();
                    var LoginForm = new LoginForm();
                    LoginForm.Closed += (s, args) => this.Close();
                    LoginForm.Show();
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
