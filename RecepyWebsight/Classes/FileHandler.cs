using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecepyWebsight.Classes
{
    public static class FileHandler
    {
        public static void AddAdmin(Admins admin)
        {
            string filePath = @"..\..\TextFiles\Admin.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(admin.Name + "," + admin.Password + "," + admin.Email);
                }
            }
            catch
            {

            }
        }


    }
}
