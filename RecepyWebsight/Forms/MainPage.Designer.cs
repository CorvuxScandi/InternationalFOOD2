namespace RecepyWebsight
{
    partial class FrmCookBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdSerch = new System.Windows.Forms.Button();
            this.numRecepie = new System.Windows.Forms.NumericUpDown();
            this.ImgFood = new System.Windows.Forms.PictureBox();
            this.lstRecepie = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmFoodType = new System.Windows.Forms.ComboBox();
            this.txtSerch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRecepie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.AutoSize = true;
            this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(19, 19);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(10);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(141, 39);
            this.cmdLogin.TabIndex = 1;
            this.cmdLogin.Text = "Logga In";
            this.cmdLogin.UseVisualStyleBackColor = true;
            // 
            // cmdEdit
            // 
            this.cmdEdit.AutoSize = true;
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(19, 78);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(10);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(206, 39);
            this.cmdEdit.TabIndex = 3;
            this.cmdEdit.Text = "Redigera Recept";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Visible = false;
            // 
            // cmdSerch
            // 
            this.cmdSerch.AutoSize = true;
            this.cmdSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSerch.Location = new System.Drawing.Point(139, 296);
            this.cmdSerch.Margin = new System.Windows.Forms.Padding(5);
            this.cmdSerch.Name = "cmdSerch";
            this.cmdSerch.Size = new System.Drawing.Size(93, 39);
            this.cmdSerch.TabIndex = 5;
            this.cmdSerch.Text = "Sök";
            this.cmdSerch.UseVisualStyleBackColor = true;
            // 
            // numRecepie
            // 
            this.numRecepie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRecepie.Location = new System.Drawing.Point(8, 211);
            this.numRecepie.Margin = new System.Windows.Forms.Padding(5);
            this.numRecepie.Name = "numRecepie";
            this.numRecepie.Size = new System.Drawing.Size(120, 30);
            this.numRecepie.TabIndex = 1;
            this.numRecepie.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ImgFood
            // 
            this.ImgFood.Location = new System.Drawing.Point(11, 19);
            this.ImgFood.Name = "ImgFood";
            this.ImgFood.Size = new System.Drawing.Size(221, 181);
            this.ImgFood.TabIndex = 2;
            this.ImgFood.TabStop = false;
            // 
            // lstRecepie
            // 
            this.lstRecepie.BackColor = System.Drawing.Color.Snow;
            this.lstRecepie.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstRecepie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecepie.FormattingEnabled = true;
            this.lstRecepie.HorizontalScrollbar = true;
            this.lstRecepie.ItemHeight = 29;
            this.lstRecepie.Location = new System.Drawing.Point(240, 22);
            this.lstRecepie.Name = "lstRecepie";
            this.lstRecepie.Size = new System.Drawing.Size(430, 546);
            this.lstRecepie.TabIndex = 4;
            this.lstRecepie.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmFoodType);
            this.groupBox1.Controls.Add(this.txtSerch);
            this.groupBox1.Controls.Add(this.cmdSerch);
            this.groupBox1.Controls.Add(this.lstRecepie);
            this.groupBox1.Controls.Add(this.numRecepie);
            this.groupBox1.Controls.Add(this.ImgFood);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(262, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 571);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cbmFoodType
            // 
            this.cbmFoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmFoodType.FormattingEnabled = true;
            this.cbmFoodType.Location = new System.Drawing.Point(8, 298);
            this.cbmFoodType.Margin = new System.Windows.Forms.Padding(5);
            this.cbmFoodType.Name = "cbmFoodType";
            this.cbmFoodType.Size = new System.Drawing.Size(121, 33);
            this.cbmFoodType.TabIndex = 6;
            // 
            // txtSerch
            // 
            this.txtSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerch.Location = new System.Drawing.Point(8, 251);
            this.txtSerch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.Size = new System.Drawing.Size(221, 35);
            this.txtSerch.TabIndex = 5;
            // 
            // FrmCookBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 571);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdEdit);
            this.Name = "FrmCookBook";
            this.Text = "International FOOD AB";
            ((System.ComponentModel.ISupportInitialize)(this.numRecepie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdSerch;
        private System.Windows.Forms.NumericUpDown numRecepie;
        private System.Windows.Forms.PictureBox ImgFood;
        private System.Windows.Forms.ListBox lstRecepie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmFoodType;
        private System.Windows.Forms.TextBox txtSerch;
    }
}

