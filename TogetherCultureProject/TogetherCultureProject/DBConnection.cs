using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                _instance = new DBConnection();         
            return _instance;
        }

        public DataSet getDataSet(string sqlQuery)
        {
            //creates dataset object    
            DataSet dataset = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //opens connection to database
                connToDB.Open();

                //sends query to connected database
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fills in dataset
                adapter.Fill(dataset);
            }
            return dataset;
        }

        //saves the captured values in parameters to the appropriate database columns
        public void saveToDB(string sqlQuery, string firstname, string lastname,
            int phonenumber, string email, string address, string towncity, string postcode, string password)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //opens connection to database
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                //sets sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("FirstName", firstname));
                sqlCommand.Parameters.Add(new SqlParameter("LastName", lastname));
                sqlCommand.Parameters.Add(new SqlParameter("PhoneNumber", phonenumber));
                sqlCommand.Parameters.Add(new SqlParameter("Email", email));
                sqlCommand.Parameters.Add(new SqlParameter("Address", address));
                sqlCommand.Parameters.Add(new SqlParameter("TownCity", towncity));
                sqlCommand.Parameters.Add(new SqlParameter("Postcode", postcode));
                sqlCommand.Parameters.Add(new SqlParameter("Password", password));
                //executes command
                sqlCommand.ExecuteNonQuery();
            }
        }   
    }
}
