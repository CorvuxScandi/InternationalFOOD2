using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RecepyWebsight.Classes
{
    public class RecipeType
    {
        public string Type { get; set; }

        public RecipeType(string type)
        {
            this.Type = type;
        }

    }
}
