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
    }
}
