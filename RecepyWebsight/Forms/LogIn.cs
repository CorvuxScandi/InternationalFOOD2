using RecepyWebsight.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepyWebsight.Forms
{
    public partial class LogIn : Form
    {
        private FrmCookBook frm1;

        public LogIn(FrmCookBook frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }
        #region EVENTS, DO NOT USE
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(FileHandler.Login(txtUsername.Text, txtPassword.Mask))
            {
                frm1.ShowEdit();
                this.Close();
            }
            else
            {

            }

        }
    }
}
