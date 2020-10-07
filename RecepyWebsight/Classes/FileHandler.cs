using System;
using System.IO;

namespace RecepyWebsight.Classes
{
    public static class FileHandler
    {
        public static void AddAdmin(Admins admin)
        {
            string filePath = @"..\..\TextFiles\Admins.txt";
            string line;
            bool userExist = false;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] adminCheck = line.Split(',');

                        if (adminCheck[0] == admin.Name)
                        {
                            userExist = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Exception
            }

            if (userExist)
            {
                // TODO: Exception [En användare med det namnet existerar redan]
            }
            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(admin.Name + "," + admin.Password + "," + admin.Email);
                    }
                }
                catch (Exception ex)
                {
                    // TODO: Exception
                }
            }
        }

        public static bool Login(string username, string password)
        {
            string filePath = @"..\..\TextFiles\Admins.txt";
            string line;
            bool loginSuccessful = false;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] adminCheck = line.Split(',');

                        if (adminCheck[0] == username && adminCheck[1] == password)
                        {
                            loginSuccessful = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Exception
            }

            return loginSuccessful;
        }

        public static void AddRecpie(Recipe recipe)
        {

        }

        public static void GetRecipe()
        {

        }

        public static void UpdateRecipe()
        {

        }
    }
}
