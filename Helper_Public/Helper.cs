using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows
{
    public static class Helper
    {
        public static string CnnVal(string Login)
        {
            return ConfigurationManager.ConnectionStrings[Login].ConnectionString;
        }
    }
}
