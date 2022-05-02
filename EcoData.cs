using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ecolog
{/// <summary>
/// Controls the database
/// -Can Register users
/// -Can Update Users
/// -Can Delete Users
/// </summary>
    class EcoData
    {
        
        // If user is found, if they can register
        Boolean foundUser, canRegister;
        
        //Username Password Email FirstName LastName ZipCode
        string unED, pwED, emailED, fnED, lnED, zipED;
        string query;
        // UserID Entries Table Rows
        int userID, entries, rows;
        
        // Footprints Total Average LastLog Offset
        double totalFP, offsetFP, lastLogFP, avgFP;

        // SQL Objects
        //!!!NOTE: CONNECTIONSTRING MUST BE CHANGED ONCE EXTRACTED, FILE PATH WILL BE CHANGED!!!
        SqlConnection ecoNet = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Edwin Knight\Desktop\Senior_Project\Ecolog\EcologDB.mdf; Integrated Security = True");// Open and closes connection with connection string 
        SqlCommand ecoStat; // Executes SQL Funtions
        SqlDataReader ecoReader; // Reads back info
        SqlDataAdapter ecoSDA = new SqlDataAdapter();
        DataTable ecoDT = new DataTable();
        //SQL Parameters
        SqlParameter userPM = new SqlParameter();
        // Create Tables
        public void CreateTables() 
        {
            //!!!NOTE: CONNECTIONSTRING MUST BE CHANGED TO MATCH FILEPATH!!!
            ecoNet = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Edwin Knight\Desktop\Senior_Project\Ecolog\EcologDB.mdf; Integrated Security = True");
            ecoNet.Close();
        }
        //To login users
        public bool UserValid(string username, string password) 
        {
            foundUser = false;
            unED = username;
            pwED = password;
            //SELECT Username, Password FROM Users where Username = @Username AND Password = @Password;
            ecoNet.Open(); // Opens Connection
            query = $"SELECT Username, Password FROM [Users] where Username ='{unED}' AND Password ='{pwED}'";

            ecoSDA = new SqlDataAdapter(query, ecoNet);
                     
            ecoSDA.Fill(ecoDT); // Fill the DataAdapter with the DataTable
            if(ecoDT.Rows.Count == 1) 
            {
                foundUser = true;
                Console.WriteLine("User Successfully validated.");
            }
            else 
            {
                MessageBox.Show("User or Password does not match.");
            }
            ecoNet.Close();
            return foundUser;
        }
        // Insert Users
        public void RegUser(string username, string password, string email, string firstName, string lastName, string zipCode) 
        {
            //Boolean
            //Checks to to see if the user can register

            //open the connection
            //set the values
            unED = username;
            pwED = password;
            emailED = email;
            fnED = firstName;
            lnED = lastName;
            zipED = zipCode;
            //ecoNet = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Edwin Knight\Desktop\Senior_Project\Ecolog\EcologDB.mdf; Integrated Security = True");
           
            // return canRegister;
            try 
            {
                ecoStat.Connection = ecoNet; // Creation the connection
                ecoNet.Open();
                //Run the query
                // INSERT INTO User VALUES(unED, pwED, emailED, fnameED, lnameED, Zip)
                //Query that will executed
                query = "INSERT INTO [Users](Username, Password, Email, FirstName, LastName, ZipCode) VALUES(@Username, @Password, @Email, @FirstName, @LastName, @ZipCode)";
                ecoStat.CommandText = query;
                ecoStat.Parameters.AddWithValue("@Username", unED);
                ecoStat.Parameters.AddWithValue("@Password", pwED);
                ecoStat.Parameters.AddWithValue("@Email", emailED);
                ecoStat.Parameters.AddWithValue("@FirstName", fnED);
                ecoStat.Parameters.AddWithValue("@LastName", lnED);
                ecoStat.Parameters.AddWithValue("@ZipCode", zipED);
                ecoStat.ExecuteNonQuery(); //Executes the command
                ecoNet.Close(); // Close the Connection
                Console.WriteLine("User Successfully Registered");
            }
            catch 
            {
                Console.WriteLine("ERROR: User Registeration Failed");
                //False boolean
            }
        }
        // Select Users
        public bool UserFound(string username) 
        {
            foundUser = false;
            unED = username;
            // SELECT Username FROM Users WHERE username = {unED}

            ecoNet.Open();
            query = $"SELECT Username, Password FROM [Users] where Username ='{unED}'";

            ecoSDA = new SqlDataAdapter(query, ecoNet);

            ecoSDA.Fill(ecoDT); // Fill the DataAdapter with the DataTable
            if(ecoDT.Rows.Count > 1)
            {
                foundUser = true;
            }
            else
            {
                Console.WriteLine("Username Not Found");
            }
            ecoNet.Close();//Close the connection
            return foundUser;
        }
        public bool EmailFound(string email) 
        {
            foundUser = true;
            emailED = email;
            // SELECT Email From Users WHERE email = '{emailED}';
            query = "SELECT Email From Users WHERE email = @email";
            ecoNet.Open();
            ecoStat.Parameters.AddWithValue("@email", emailED);
           
            ecoNet.Close();//Close the connection
            return foundUser;
        }
        
        //SELECT FirstName FROM Users WHERE username = {unED}
        
        //SELECT LastName FROM Users WHERE username = {unED}
        
        //SELECT ZipCode FROM Users WHERE username = {unED}

       
        // Update Users
        //Breakup
        public void UpdateEmail(string username, string email) 
        {
            //Set the variables
            unED = username;
           
            emailED = email;

            ecoNet.Open();

            ecoNet.Close();//Close the connection


            //create string variables
            string success = "Account Updated Successfully";
            string failed = "Update Procedure Failed";
            string result; // whether it was successful or failed
            string update = $"UPDATE Users SET Pass WHERE Username = '{unED}'   ";
            //Run queries
            // SELECT Email, Password, FirstName, LastName, Zip
            // FROM Users
            // WHERE username = '{unEd}' 
            // Look for a match

            //UPDATE SET WHERE 
            
        }
        public void PasswordUpdate(string username, string password, string email) 
        {
            unED = username;
            pwED = password;
            ecoNet.Open();

            ecoNet.Close();//Close the connection
        }

        public void FirstNameUpdate(string username, string fname) 

        {
            unED = username;
            fnED = fname;
            ecoNet.Open();

            ecoNet.Close();//Close the connection
        }
        public void LastNameUpdate(string username, string lname) 
        {
            unED = username;
            lnED = lname;
            ecoNet.Open();

            ecoNet.Close();//Close the connection
        }
        public void ZipUpdate(string username, string zipCode)
        {
            unED = username;
            zipED = zipCode;
            ecoNet.Open();

            ecoNet.Close();//Close the connection
        }
        // Delete Users
        public bool DeleteUser(string username) 
        {
            //Set the values
            unED = username;
            // DELETE FROM Footprint WHERE userID = '{userID}'
            //WHERE Users.UserID = Footprint.UserID;
            // DELETE FROM Users WHERE Username = '{unED}'
            ecoNet.Open();

            ecoNet.Close();//Close the connection
            return foundUser;
            
        }
        //Find number of rows to calculate
        public int RowCalc()
        {
            //Select Count(*)

            ecoNet.Open();

            ecoNet.Close();//Close the connection
            return rows;
        }
        // Users IDs
        public int UserIDLook(string username) 
        {
            unED = username;
            // SELECT userID FROM Users WHERE username = '{unED}';
            query = "SELECT UserID FROM Users WHERE Username = @Username";
            ecoNet.Open();

            ecoNet.Close();//Close the connection
            return userID;
        }
        // Insert Footprints
        // Update Footprint SET LastLog WHERE userid = '{userID}';
        // Update Footprint SET LastLog WHERE userid = '{userID}';
        // Update Footprint SET LastLog WHERE userid = '{userID}';
        // Update Footprint SET  WHERE userid = '{userID}';
        // Update Footprint SET Offset WHERE userid = '{userID}';
        // Select Footprints

        public double TotalQuery(string username) 
        {
            //SELECT Total FROM Footprint WHERE userID = '{userID}' 
            ecoNet.Close();
            return totalFP;
        }
        public int EntriesQuery(string username) 
        {
            //SELECT Entries FROM Footprint WHERE userID = '{userID}'
            ecoNet.Close();
            return entries;
        }

        public double AverageQuery(string username) 
        {
            //SELECT Average FROM Footprint WHERE userID = '{userID}'
            ecoNet.Close();
            return avgFP;
        }
        public double OffsetQuery(string username)
        {
            //SELECT LastLog FROM Footprint WHERE userID = '{userID}'
            ecoNet.Close();
            return offsetFP;
        }

        public double LastLogQuery(string username)
        {
            //SELECT Offeset FROM Footprint WHERE userID = '{userID}'
            ecoNet.Open();

            ecoNet.Close();
            return lastLogFP;
        }
        // Update Footprints

        // Delete Footprints
        public void DeleteFootprint() 
        {
            // DELETE FROM Footprint WHERE UserID = @userid;
        }
    }
}
