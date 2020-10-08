using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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


        public static void AddRecipe(Recipe recipe)
        {
            string filePath = @"..\..\TextFiles\Recepies.txt";
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

        public static List<Recipe> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            string filePath = @"..\..\TextFiles\Recepies.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeArray = line.Split('#');

                        RecipeType type = new RecipeType(recipeArray[3]);
                        Recipe recipe = new Recipe(recipeArray[0], recipeArray[1].Split('-').ToList(), recipeArray[2].Split('-').ToList(), type);

                        recipes.Add(recipe);
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Exception
            }

            return recipes;
        }

        public static void UpdateRecipe(string headline, List<string> ingredients, List<string> instructions, string type)
        {
            StringBuilder sb = new StringBuilder();
            List<string> updatedList = new List<string>();
            string filePath = @"..\..\TextFiles\Recepies.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeCheck = line.Split(',');

                        if (recipeCheck[0] == headline)
                        {
                            sb.Append(headline);

                            sb.Append(",");
                            foreach(string ingredient in ingredients)
                            {
                                sb.Append(ingredient + "-");
                            }

                            sb.Append(",");
                            foreach(string instruction in instructions)
                            {
                                sb.Append(instruction + "-");
                            }

                            sb.AppendLine(type);

                            updatedList.Add(sb.ToString());
                        }
                        else
                        {
                            updatedList.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Exception
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach(string recipe in updatedList)
                    {
                        writer.WriteLine(recipe);
                    }
                }
            }
            catch(Exception ex)
            {
                // TODO: Exception
            }
        }

        public static void RemoveRecipe(string headline)
        {
            List<string> updatedList = new List<string>();
            string filePath = @"..\..\TextFiles\Recepies.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeCheck = line.Split(',');

                        if (recipeCheck[0] != headline)
                        {
                            updatedList.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Exception
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string recipe in updatedList)
                    {
                        writer.WriteLine(recipe);
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Exception
            }
        }
    }
}
