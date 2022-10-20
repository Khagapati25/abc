using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpecFlow.Configure
{
     public class ConfigureManager
    {
        public  static string url = TestContext.Parameters.Get("url");
        public static string username = TestContext.Parameters.Get("username");
        public static string password = TestContext.Parameters.Get("password");

        
    }
}
