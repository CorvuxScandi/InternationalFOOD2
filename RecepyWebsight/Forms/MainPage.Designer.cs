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
            this.components = new System.ComponentModel.Container();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdSerch = new System.Windows.Forms.Button();
            this.numRecepie = new System.Windows.Forms.NumericUpDown();
            this.ImgFood = new System.Windows.Forms.PictureBox();
            this.lstRecepie = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmFoodType = new System.Windows.Forms.ComboBox();
            this.txtSerch = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numRecepie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.AutoSize = true;
            this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(13, 12);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(94, 30);
            this.cmdLogin.TabIndex = 1;
            this.cmdLogin.Text = "Logga In";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.AutoSize = true;
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(13, 51);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(140, 30);
            this.cmdEdit.TabIndex = 3;
            this.cmdEdit.Text = "Redigera Recept";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Visible = false;
            // 
            // cmdSerch
            // 
            this.cmdSerch.AutoSize = true;
            this.cmdSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSerch.Location = new System.Drawing.Point(93, 192);
            this.cmdSerch.Name = "cmdSerch";
            this.cmdSerch.Size = new System.Drawing.Size(62, 30);
            this.cmdSerch.TabIndex = 5;
            this.cmdSerch.Text = "Sök";
            this.cmdSerch.UseVisualStyleBackColor = true;
            // 
            // numRecepie
            // 
            this.numRecepie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRecepie.Location = new System.Drawing.Point(5, 137);
            this.numRecepie.Name = "numRecepie";
            this.numRecepie.Size = new System.Drawing.Size(80, 23);
            this.numRecepie.TabIndex = 1;
            this.numRecepie.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ImgFood
            // 
            this.ImgFood.Location = new System.Drawing.Point(7, 12);
            this.ImgFood.Margin = new System.Windows.Forms.Padding(2);
            this.ImgFood.Name = "ImgFood";
            this.ImgFood.Size = new System.Drawing.Size(147, 118);
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
            this.lstRecepie.ItemHeight = 20;
            this.lstRecepie.Location = new System.Drawing.Point(159, 15);
            this.lstRecepie.Margin = new System.Windows.Forms.Padding(2);
            this.lstRecepie.Name = "lstRecepie";
            this.lstRecepie.Size = new System.Drawing.Size(288, 354);
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
            this.groupBox1.Location = new System.Drawing.Point(174, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(449, 371);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cbmFoodType
            // 
            this.cbmFoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmFoodType.FormattingEnabled = true;
            this.cbmFoodType.Location = new System.Drawing.Point(5, 194);
            this.cbmFoodType.Name = "cbmFoodType";
            this.cbmFoodType.Size = new System.Drawing.Size(82, 24);
            this.cbmFoodType.TabIndex = 6;
            // 
            // txtSerch
            // 
            this.txtSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerch.Location = new System.Drawing.Point(5, 163);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.Size = new System.Drawing.Size(149, 26);
            this.txtSerch.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmCookBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 371);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdEdit);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ImageList imageList1;
    }
}

