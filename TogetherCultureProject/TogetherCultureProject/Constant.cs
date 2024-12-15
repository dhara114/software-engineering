using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCultureProject
{
    class Constant
    {
        //selects all data in User table
        public static string SELECTALLUser = "SELECT * FROM [User]";
        //inserts into all columns of a row in User table
        public static string INSERTALLUser = "INSERT INTO [User] (FirstName, LastName, PhoneNumber, Email, Address, TownCity, Postcode, Password)" +
                "VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address, @TownCity, @Postcode, @Password)";
    }
}
