﻿using System.Configuration;

namespace Ecolog
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }
    }
}
