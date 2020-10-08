﻿using System;
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

                        if (adminCheck[2] == admin.Username)
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
                    using(StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(admin.Firstname + "," + admin.Lastname + "," + admin.Username + "," + admin.Password + "," + admin.Email);
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

        // Lägger ett "-" framför varje ingrediens och numrerar varje instruktion
        public static void AddRecpie(Recipe recipe)
        {
            string filePath = @"..\..\TextFiles\Recepies.txt";
            int instructionNumber = 1;
            string line;
            bool recpieExist = false;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeCheck = line.Split(',');

                        if (recipeCheck[0] == recipe.Name)
                        {
                            recpieExist = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Exception
            }

            if (recpieExist)
            {
                // TODO: Felhantering - Ett recept med namnet existerar redan
            }
            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.Write(recipe.Name);

                        writer.Write(",");
                        foreach (string ingredient in recipe.Ingredients)
                        {
                            writer.Write(ingredient + "-");
                        }

                        writer.Write(",");
                        foreach (string instruction in recipe.Instructions)
                        {
                            writer.Write(instruction + "-");
                            instructionNumber++;
                        }

                        writer.Write("," + recipe.Type + "\n");
                    }
                }
                catch (Exception ex)
                {
                    // TODO: Exception
                }
            }
        }
    }
}
