using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ecolog
{/// <summary>
/// Controls the database
/// -Can Register users
/// -Can Update Users
/// -Can Delete Users
/// </summary>
    class EcoData
    {
        //Boolean values
        // Boolean 
        // Create Tables
        public void CreateTables() 
        {
            SqlConnection ecoNet = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Ecolog\EcoData.mdf;Integrated Security=True");
            ecoNet.Close();
        }
        // Insert Users
        public bool RegUser(string username, string password, string email, string firstName, string lastName, int zipCode) 
        {
            //Boolean
            throw new NotImplementedException();
        }
        // Select Users
        public bool UserFound(string username, string Email)
        {
            throw new NotImplementedException();
        }
        // Update Users
        public void UpdateUser(string username) 
        {

            throw new NotImplementedException();
        }
        // Delete Users
        public bool DeleteUser(string username) 
        {

            throw new NotImplementedException();
        }
        
        
        // Insert Footprints
        public bool UpdateFootprint(double fpEntry)
        {
            throw new NotImplementedException();
        }
        // Select Footprints
        public double FindTotal(string username)
        {
            throw new NotImplementedException();
        }
        public int FindEntries(string username)
        {
            throw new NotImplementedException();
        }

        public double FindAverage(string username)
        {
            throw new NotImplementedException();
        }
        public double FindOffset(string username)
        {
            throw new NotImplementedException();
        }

        public double FindLastLog(string username)
        {
            throw new NotImplementedException();
        }
        // Update Footprints

        // Delete Footprints

    }
}
