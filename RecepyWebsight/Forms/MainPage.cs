﻿using RecepyWebsight.Classes;
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
            


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //lstRecipe
        {
            int currentRecipeIndex = int.Parse(numRecepie.Value.ToString());

            ImgFood.Image = imageList1.Images[currentRecipeIndex - 1];
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



            }

        }
    }
}
