namespace RecepyWebsight.Forms
{
    partial class EditDeleteRecipe
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
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblInstruktions = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.txtHeadline = new System.Windows.Forms.TextBox();
            this.cmdAddRecipe = new System.Windows.Forms.Button();
            this.cmdEditRecipe = new System.Windows.Forms.Button();
            this.cmdDeleteRecipe = new System.Windows.Forms.Button();
            this.cboRecipeType = new System.Windows.Forms.ComboBox();
            this.lblRecipeType = new System.Windows.Forms.Label();
            this.txtAddRecipeType = new System.Windows.Forms.TextBox();
            this.cmdAddRecipeType = new System.Windows.Forms.Button();
            this.lblAddRecipeType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Location = new System.Drawing.Point(58, 26);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(38, 13);
            this.lblHeadline.TabIndex = 0;
            this.lblHeadline.Text = "Rubrik";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(58, 126);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(65, 13);
            this.lblIngredients.TabIndex = 1;
            this.lblIngredients.Text = "Ingredienser";
            // 
            // lblInstruktions
            // 
            this.lblInstruktions.AutoSize = true;
            this.lblInstruktions.Location = new System.Drawing.Point(58, 291);
            this.lblInstruktions.Name = "lblInstruktions";
            this.lblInstruktions.Size = new System.Drawing.Size(65, 13);
            this.lblInstruktions.TabIndex = 2;
            this.lblInstruktions.Text = "Instruktioner";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(61, 307);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(318, 152);
            this.txtInstructions.TabIndex = 3;
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(61, 142);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(318, 134);
            this.txtIngredients.TabIndex = 4;
            // 
            // txtHeadline
            // 
            this.txtHeadline.Location = new System.Drawing.Point(61, 42);
            this.txtHeadline.Name = "txtHeadline";
            this.txtHeadline.Size = new System.Drawing.Size(191, 20);
            this.txtHeadline.TabIndex = 5;
            // 
            // cmdAddRecipe
            // 
            this.cmdAddRecipe.Location = new System.Drawing.Point(61, 474);
            this.cmdAddRecipe.Name = "cmdAddRecipe";
            this.cmdAddRecipe.Size = new System.Drawing.Size(104, 23);
            this.cmdAddRecipe.TabIndex = 6;
            this.cmdAddRecipe.Text = "Lägg till recept";
            this.cmdAddRecipe.UseVisualStyleBackColor = true;
            this.cmdAddRecipe.Click += new System.EventHandler(this.cmdAddRecipe_Click);
            // 
            // cmdEditRecipe
            // 
            this.cmdEditRecipe.Location = new System.Drawing.Point(171, 474);
            this.cmdEditRecipe.Name = "cmdEditRecipe";
            this.cmdEditRecipe.Size = new System.Drawing.Size(104, 23);
            this.cmdEditRecipe.TabIndex = 7;
            this.cmdEditRecipe.Text = "Uppdatera recept";
            this.cmdEditRecipe.UseVisualStyleBackColor = true;
            this.cmdEditRecipe.Click += new System.EventHandler(this.cmdEditRecipe_Click);
            // 
            // cmdDeleteRecipe
            // 
            this.cmdDeleteRecipe.Location = new System.Drawing.Point(281, 474);
            this.cmdDeleteRecipe.Name = "cmdDeleteRecipe";
            this.cmdDeleteRecipe.Size = new System.Drawing.Size(98, 23);
            this.cmdDeleteRecipe.TabIndex = 8;
            this.cmdDeleteRecipe.Text = "Ta bort";
            this.cmdDeleteRecipe.UseVisualStyleBackColor = true;
            this.cmdDeleteRecipe.Click += new System.EventHandler(this.cmdDeleteRecipe_Click);
            // 
            // cboRecipeType
            // 
            this.cboRecipeType.FormattingEnabled = true;
            this.cboRecipeType.Location = new System.Drawing.Point(258, 42);
            this.cboRecipeType.Name = "cboRecipeType";
            this.cboRecipeType.Size = new System.Drawing.Size(121, 21);
            this.cboRecipeType.TabIndex = 9;
            // 
            // lblRecipeType
            // 
            this.lblRecipeType.AutoSize = true;
            this.lblRecipeType.Location = new System.Drawing.Point(255, 26);
            this.lblRecipeType.Name = "lblRecipeType";
            this.lblRecipeType.Size = new System.Drawing.Size(56, 13);
            this.lblRecipeType.TabIndex = 10;
            this.lblRecipeType.Text = "Recepttyp";
            // 
            // txtAddRecipeType
            // 
            this.txtAddRecipeType.Location = new System.Drawing.Point(61, 92);
            this.txtAddRecipeType.Name = "txtAddRecipeType";
            this.txtAddRecipeType.Size = new System.Drawing.Size(191, 20);
            this.txtAddRecipeType.TabIndex = 11;
            // 
            // cmdAddRecipeType
            // 
            this.cmdAddRecipeType.Location = new System.Drawing.Point(258, 92);
            this.cmdAddRecipeType.Name = "cmdAddRecipeType";
            this.cmdAddRecipeType.Size = new System.Drawing.Size(114, 22);
            this.cmdAddRecipeType.TabIndex = 12;
            this.cmdAddRecipeType.Text = "Lägg till ny recepttyp";
            this.cmdAddRecipeType.UseVisualStyleBackColor = true;
            this.cmdAddRecipeType.Click += new System.EventHandler(this.cmdAddRecipeType_Click);
            // 
            // lblAddRecipeType
            // 
            this.lblAddRecipeType.AutoSize = true;
            this.lblAddRecipeType.Location = new System.Drawing.Point(58, 76);
            this.lblAddRecipeType.Name = "lblAddRecipeType";
            this.lblAddRecipeType.Size = new System.Drawing.Size(104, 13);
            this.lblAddRecipeType.TabIndex = 13;
            this.lblAddRecipeType.Text = "Lägg till ny recepttyp";
            // 
            // EditDeleteRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 542);
            this.Controls.Add(this.lblAddRecipeType);
            this.Controls.Add(this.cmdAddRecipeType);
            this.Controls.Add(this.txtAddRecipeType);
            this.Controls.Add(this.lblRecipeType);
            this.Controls.Add(this.cboRecipeType);
            this.Controls.Add(this.cmdDeleteRecipe);
            this.Controls.Add(this.cmdEditRecipe);
            this.Controls.Add(this.cmdAddRecipe);
            this.Controls.Add(this.txtHeadline);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lblInstruktions);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblHeadline);
            this.Name = "EditDeleteRecipe";
            this.Text = "Recepthanterare";
            this.Load += new System.EventHandler(this.EditDeleteRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblInstruktions;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.TextBox txtHeadline;
        private System.Windows.Forms.Button cmdAddRecipe;
        private System.Windows.Forms.Button cmdEditRecipe;
        private System.Windows.Forms.Button cmdDeleteRecipe;
        private System.Windows.Forms.ComboBox cboRecipeType;
        private System.Windows.Forms.Label lblRecipeType;
        private System.Windows.Forms.TextBox txtAddRecipeType;
        private System.Windows.Forms.Button cmdAddRecipeType;
        private System.Windows.Forms.Label lblAddRecipeType;
    }
}