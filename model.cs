using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App
{
    public class connections
    {
        public static string connectionStrings()
        {
            string connect = "Data Source=budget.db;";
            return connect;
        }
    }
}
