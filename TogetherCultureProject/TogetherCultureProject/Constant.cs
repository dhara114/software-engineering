using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCultureProject;

namespace TogetherCultureProject
{
    class Constant
    {
        //selects all data in User table
        public static string SELECTALLUser = "SELECT * FROM [User]";
        //inserts into all columns of a row in User table
        public static string INSERTALLUser = "INSERT INTO [User] (FirstName, LastName, PhoneNumber, Email, Address, TownCity, Postcode, Password)" +
                "VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address, @TownCity, @Postcode, @Password)";

        //method that validates email, must contain "@" and must not end with ".", false positives possible but safer
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
