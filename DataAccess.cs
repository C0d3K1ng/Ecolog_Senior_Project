using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Ecolog
{
    /*
        Class for database operations
     */
    class DataAccess
    {
        public List<User> GetUsers(string Username)
        {
           // throw new NotImplementedException();
            //Connects to database, begins and ends between the brackets
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EcoData")))
            {
               var output = connection.Query<User>($"SELECT * FROM Users WHERE Username ='{Username}'").ToList();
                return output;
            }
        }
    }
}
