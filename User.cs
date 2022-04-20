using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecolog
{
   /*
        Project: Ecolog
        Filename: User.cs
        Author: Evan Kern
        Date: 4/19/2022
        Creates a user instance
        Sets and gets information on users in the database
    
    */
    public class User
    {
        //Turns Database Row into Class
        public int id { get; set; }
        public String Username { get; set; }
        public String email { get; set; }
        public String firstname { get; set; }
        public String lastName { get; set; }
        public String zipCode { get; set;  }
    }
}
