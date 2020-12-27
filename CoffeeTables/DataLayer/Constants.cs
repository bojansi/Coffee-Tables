using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Constants
    {
        public static string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=CoffeeTableDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static string adminUsername = "veliko";
        public static string adminPassword = "toceno";

        public static string caffeName = "\"Veliko toceno \"";
        public static string caffeAddress = "Bulevar Tanaska Rajica 256";
        public static string caffePostalCode = "3200 Cacak";
        public static string caffePIB = "PIB : 4478596232145284";

        public static List<string> caffeInfo = new List<string>() { caffeName, caffeAddress, caffePostalCode, caffePIB };
    }
}
