using RecepyWebsight.TextFiles.Errormessage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            if (userExist)
            {
                MessageBox.Show("En användare med det användarnamnt finns redan");
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
                    ErrorHandler error = new ErrorHandler(ex);

                    error.LogException();
                }
            }
        }

        public static bool Login(string username, string password)
        {
            string filePath = @"..\..\TextFiles\Admins.txt";
            string line;
            bool loginSuccessful = false;
            List<Admins> admins = new List<Admins>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] adminC = line.Split(',');
                        admins.Add(new Admins(adminC[0], adminC[1], adminC[2], adminC[3], adminC[4]));
                    }

                }

                loginSuccessful = admins.Any(a => a.Username == username && a.Password == password);

            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            return loginSuccessful;
        }

        public static void UpdateAdmin(string firstname, string lastname, string username, string password, string email)
        {

            List<string> updatedList = new List<string>();
            string filePath = @"..\..\TextFiles\Admins.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeCheck = line.Split(',');

                        if (recipeCheck[2] == username)
                        {
                            string admin = firstname + "," + lastname + "," + username + "," + password + "," + "," + email;

                            updatedList.Add(admin);
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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string admin in updatedList)
                    {
                        writer.WriteLine(admin);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }
        }

        public static void RemoveAdmin(string adminName)
        {
            List<string> updatedList = new List<string>();
            string filePath = @"..\..\TextFiles\Admins.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] adminCheck = line.Split(',');

                        if (adminCheck[2] != adminName)
                        {
                            updatedList.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string admin in updatedList)
                    {
                        writer.WriteLine(admin);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }
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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            if (recpieExist)
            {
                MessageBox.Show("Ett recept med det namnet finns redan.");
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
                    ErrorHandler error = new ErrorHandler(ex);
                    error.LogException();
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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            return recipes;
        }

        public static void UpdateRecipe(string headline, List<string> ingredients, List<string> instructions, RecipeType type)
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

                            sb.AppendLine(type.Type);

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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
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
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }
        }

        
        public static void AddRecipeType(RecipeType recipeType)
        {
            StringBuilder sbRecipeType = new StringBuilder();
            string filePath = @"..\..\TextFiles\RecipeTypes.txt";
            string line;
            bool recpieTypeExist = false;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeTypeArray = line.Split(',');

                        foreach(string type in recipeTypeArray)
                        {
                            if(type == recipeType.Type)
                            {
                                recpieTypeExist = true;
                                break;
                            }
                            else
                            {
                                sbRecipeType.Append(type + ",");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            if (recpieTypeExist)
            {
                MessageBox.Show("En recepttype med det namnet finns redan.");
            }
            else
            {
                try
                {
                    sbRecipeType.Append(recipeType.Type);

                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.Write(sbRecipeType.ToString());
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandler error = new ErrorHandler(ex);
                    error.LogException();
                }
            }
        }

        public static List<RecipeType> GetRecipeType()
        {
            List<RecipeType> recipesTypes = new List<RecipeType>();
            string filePath = @"..\..\TextFiles\RecipeTypes.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeTypeArray = line.Split(',');

                        foreach (string recipeType in recipeTypeArray)
                        {
                            RecipeType type = new RecipeType(recipeTypeArray[0]);

                            recipesTypes.Add(type);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            return recipesTypes;
        }

        public static void UpdateRecipeType(string recipeType)
        {
            StringBuilder sbRecipeType = new StringBuilder();
            List<string> updatedList = new List<string>();
            string filePath = @"..\..\TextFiles\RecipeTypes.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeTypeArray = line.Split(',');

                        foreach(string type in recipeTypeArray)
                        {
                            if(type == recipeType)
                            {
                                sbRecipeType.Append(recipeType + ",");
                            }
                            else
                            {
                                sbRecipeType.Append(type + ",");
                            }                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string type in updatedList)
                    {
                        writer.WriteLine(type);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }
        }

        public static void RemoveRecipeType(string recipeType)
        {
            StringBuilder sbRecipeType = new StringBuilder();
            List<string> updatedList = new List<string>();
            string filePath = @"..\..\TextFiles\RecipeTypes.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] recipeTypeArray = line.Split(',');

                        foreach (string type in recipeTypeArray)
                        {
                            if (type != recipeType)
                            {
                                sbRecipeType.Append(type + ",");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string type in updatedList)
                    {
                        writer.WriteLine(type);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler(ex);
                error.LogException();
            }
        }
    }
}
