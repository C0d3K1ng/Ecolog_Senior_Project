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
        Boolean 
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
            
        }
        // Select Users
        public bool UserFound(string username, string Email) 
        { 
        }
        // Update Users
        public void UpdateUser(string username) { }
        // Delete Users
        public bool DeleteUser(string username) { }
        
        
        // Insert Footprints
        public bool UpdateFootprint(double fpEntry) 
        { 
        
        }
        // Select Footprints
        public double FindTotal(string username) { }
        public int FindEntries(string username) { }

        public double FindAverage(string username) { }
        public double FindOffset(string username) { }

        public double FindLastLog(string username) { }
        // Update Footprints

        // Delete Footprints

    }
}
