using RecepyWebsight.Classes;
using RecepyWebsight.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepyWebsight
{
    public partial class FrmCookBook : Form
    {
        

        public FrmCookBook()
        {
            InitializeComponent();
            ToListbox();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //lstRecipe
        {
            // int currentRecipeIndex = int.Parse(numRecepie.Value.ToString());

            

            numRecepie.Value = lstRecepie.SelectedIndex;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {



        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn(this);
            
                logIn.Show();

        }

        public void ShowEdit()
        {
            cmdEdit.Visible = true;
        }

        private void ToListbox()
        {
            List<Recipe> recipes = FileHandler.GetRecipes();

            foreach (var recipe in recipes)
            {
                lstRecepie.Items.Add(recipe.Name);
                
                foreach (var item in recipe.Ingredients)
                {
                    lstRecepie.Items.Add(item);
                }
                foreach (var item in recipe.Instructions)
                {
                    lstRecepie.Items.Add(item);
                }

                lstRecepie.Items.Add(" ");
            }

        }

        private void GetImage()
        {
            List<Recipe> recipes = FileHandler.GetRecipes();
            int targetRecipeIndex = recipes.IndexOf((Recipe)recipes.Where(r => r.Name == lstRecepie.SelectedItem.ToString()));

            ImgFood.Image = imageList1.Images[ ];
        }
    }
}
