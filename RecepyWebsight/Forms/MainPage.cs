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
        List<Recipe> recipes = FileHandler.GetRecipes();

        public FrmCookBook()
        {

           
            InitializeComponent();
            //numRecepie.Value = 1;
            ToListbox(recipes[Convert.ToInt32(numRecepie.Value - 1)]);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //lstRecipe
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numRecepie.Maximum = recipes.Count;
            
            ToListbox(recipes[Convert.ToInt32(numRecepie.Value - 1)]);

           
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

        private void ToListbox(Recipe recipe)
        {
            lstRecepie.Items.Clear();

            lstRecepie.Items.Add(recipe.Name);
                
                foreach (var ingredient in recipe.Ingredients)
                {
                    lstRecepie.Items.Add(ingredient);
                }
                foreach (var row in recipe.Instructions)
                {
                    lstRecepie.Items.Add(row);
                }

        }
        private void SearchToListbox(List<Recipe> recipes)
        {
            lstRecepie.Items.Clear();

            foreach (var recipe in recipes)
            {

                lstRecepie.Items.Add(recipe.Name);

                foreach (var ingredient in recipe.Ingredients)
                {
                    lstRecepie.Items.Add(ingredient);
                }
                foreach (var row in recipe.Instructions)
                {
                    lstRecepie.Items.Add(row);
                }
            }
        }
        

        private void GetImage()
        {
           
            int targetRecipeIndex = recipes.IndexOf((Recipe)recipes.Where(r => r.Name == lstRecepie.SelectedItem.ToString()));

            ImgFood.Image = imageList1.Images[Convert.ToInt32(numRecepie.Value - 1)];
        }

        private void cmdSerch_Click(object sender, EventArgs e)
        {
            Serch search = new Serch();

            if(cbmFoodType.SelectedItem == null)
            {
                SearchToListbox(search.Search("", txtSerch.Text));
            }
            else
            {
                SearchToListbox(search.Search(txtSerch.Text, cbmFoodType.SelectedItem.ToString()));
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            EditDeleteRecipe edit = new EditDeleteRecipe();

            edit.Show();
        }

        private void GetTypes()
        {
            cbmFoodType.Items.Clear();
            foreach (var item in FileHandler.GetRecipeType())
            {
                cbmFoodType.Items.Add(item.Type);
            }
        }

        private void cbmFoodType_Click(object sender, EventArgs e)
        {
            GetTypes();
        }
    }
}
