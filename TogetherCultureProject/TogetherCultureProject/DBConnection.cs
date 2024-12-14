using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCultureProject
{
    class DBConnection
    {
        //object of class
        private static DBConnection _instance;

        //connection string
        private string dBConnectionString;

        //constructor
        private DBConnection()
        {
            //initialises dBConnectionString
            dBConnectionString = Properties.Settings.Default.DBConnectionString;
        }

        //methods
        //gives access to private object

        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }
    }
}
