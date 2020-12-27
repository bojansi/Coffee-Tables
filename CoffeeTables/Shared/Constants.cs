using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Constants
    {
        public static Color tableTaken = Color.FromArgb(255, 37, 37);
        public static Color tableAvailable = Color.FromArgb(128, 255, 128);
        public static Color buttonUpdate = Color.FromArgb(29, 160, 255);
        public static Color buttonAdd = Color.FromArgb(99, 205, 99);
        public static Color buttonDelete = Color.FromArgb(255, 37, 37);
        public static Color buttonCharge = Color.FromArgb(229, 255, 67);

         public static string adminUsername = "veliko";
        public static string adminPassword = "toceno";

        public static string caffeName = "\"Veliko toceno \"";
        public static string caffeAddress = "Bulevar Tanaska Rajica 256";
        public static string caffePostalCode = "3200 Cacak";
        public static string caffePIB = "PIB : 4478596232145284";

        public static List<string> caffeInfo = new List<string>() { caffeName, caffeAddress, caffePostalCode, caffePIB };
    }
}
