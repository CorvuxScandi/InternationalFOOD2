using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepyWebsight.Classes
{
    public class Recipe
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
        public RecipeType Type { get; set; }

        public Recipe(string name, int id, List<string> ingredients, List<string> instructions, RecipeType type)
        {
            this.Name = name;
            this.Id = id;
            this.Ingredients = ingredients;
            this.Instructions = instructions;
            this.Type = type; 
        }

    }
}
