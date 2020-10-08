using RecepyWebsight.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepyWebsight.Forms
{
    public partial class EditDeleteRecipe : Form
    {
        public EditDeleteRecipe()
        {
            InitializeComponent();
        }

        private void EditDeleteRecipe_Load(object sender, EventArgs e)
        {
            //Tillgängliga recepttyper läggs till i combobox
            List<RecipeType> recipeTypes = FileHandler.GetRecipeType();

            foreach (var item in recipeTypes)
            {
                cboRecipeType.Items.Add(item.Type);
            }
        }

        private void cmdAddRecipeType_Click(object sender, EventArgs e)
        {


            if (txtAddRecipeType.Text == "")
            {
                MessageBox.Show("Du har inte fyllt i någon ny recepttyp.");
            }
            else
            {
                RecipeType recipeType = new RecipeType(txtAddRecipeType.Text);
                FileHandler.AddRecipeType(recipeType);
                cboRecipeType.Items.Add(recipeType.Type); //Lägger till den nya recepttyp i combobox
            }
        }

        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            if (txtHeadline.Text == "" || cboRecipeType == null || txtIngredients.Text == "" || txtInstructions.Text == "")
            {
                MessageBox.Show("Du har inte fyllt i all information om receptet.");
            }
            else
            {
                string headLine = txtHeadline.Text;
                RecipeType recipeType = new RecipeType(cboRecipeType.SelectedItem.ToString());
                string[] ingredientArray = txtIngredients.Lines;
                string[] instructionsArray = txtInstructions.Lines;
                List<string> ingredients = ingredientArray.ToList();
                List<string> instructions = instructionsArray.ToList();
                Recipe recipe = new Recipe(txtHeadline.Text, ingredients, instructions, recipeType);
                FileHandler.AddRecipe(recipe);
            }  
        }

        private void cmdEditRecipe_Click(object sender, EventArgs e)
        {
            if (txtHeadline.Text == "" || cboRecipeType == null || txtIngredients.Text == "" || txtInstructions.Text == "")
            {
                MessageBox.Show("Du har inte fyllt i all information om receptet.");
            }
            else
            {
                string headLine = txtHeadline.Text;
                RecipeType recipeType = new RecipeType(cboRecipeType.SelectedItem.ToString());
                string type = cboRecipeType.SelectedItem.ToString();
                string[] ingredientArray = txtIngredients.Lines;
                string[] instructionsArray = txtInstructions.Lines;
                List<string> ingredients = ingredientArray.ToList();
                List<string> instructions = instructionsArray.ToList();

                FileHandler.UpdateRecipe(headLine, ingredients, instructions, recipeType);
            }
        }

        private void cmdDeleteRecipe_Click(object sender, EventArgs e)
        {
            FileHandler.RemoveRecipe(txtHeadline.Text);
        }
    }
}
