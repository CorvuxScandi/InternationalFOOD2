using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepyWebsight.Classes
{
    public class Recipe:IMaintainable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
        public RecipeType Type { get; set; }

        public Recipe(string name, int id, List<string> ingredients, List<string> instructions, RecipeType type)
        {
            Name = name;
            Id = id;
            Ingredients = ingredients;
            Instructions = instructions;
            Type = type; 
        }

        public void Save()
        {
            
        }

        public void Update()
        {
           
        }

        public void Delete()
        {
            
        }
    }
}
