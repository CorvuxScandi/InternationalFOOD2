using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepyWebsight.Classes
{
    public class Serch
    {
        List<Recipe> recipeList = FileHandler.GetRecipes();

        public List<Recipe> Search(string recipeType, string condition)
        {
            List<Recipe> searchResult;

            if (recipeType == "")
            {
                searchResult = recipeList.Where(recipe => recipe.Name.ToLower().Contains(condition.ToLower()))
                                                .OrderBy(recipe => recipe.Name).ToList();
            }
            else
            {
                searchResult = recipeList.Where(recipe => (recipe.Name.ToLower().Contains(condition.ToLower()) && 
                                                           recipe.Type.Type == recipeType))
                                                           .OrderBy(recipe => recipe.Name).ToList();
            }

            return searchResult;
        }
    }
}
