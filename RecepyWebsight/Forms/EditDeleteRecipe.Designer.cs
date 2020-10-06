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
            this.lblIngredients.Location = new System.Drawing.Point(58, 79);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(65, 13);
            this.lblIngredients.TabIndex = 1;
            this.lblIngredients.Text = "Ingredienser";
            // 
            // lblInstruktions
            // 
            this.lblInstruktions.AutoSize = true;
            this.lblInstruktions.Location = new System.Drawing.Point(58, 249);
            this.lblInstruktions.Name = "lblInstruktions";
            this.lblInstruktions.Size = new System.Drawing.Size(65, 13);
            this.lblInstruktions.TabIndex = 2;
            this.lblInstruktions.Text = "Instruktioner";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(61, 265);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(318, 152);
            this.txtInstructions.TabIndex = 3;
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(61, 95);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(318, 134);
            this.txtIngredients.TabIndex = 4;
            // 
            // txtHeadline
            // 
            this.txtHeadline.Location = new System.Drawing.Point(61, 42);
            this.txtHeadline.Name = "txtHeadline";
            this.txtHeadline.Size = new System.Drawing.Size(318, 20);
            this.txtHeadline.TabIndex = 5;
            // 
            // cmdAddRecipe
            // 
            this.cmdAddRecipe.Location = new System.Drawing.Point(61, 432);
            this.cmdAddRecipe.Name = "cmdAddRecipe";
            this.cmdAddRecipe.Size = new System.Drawing.Size(104, 23);
            this.cmdAddRecipe.TabIndex = 6;
            this.cmdAddRecipe.Text = "Lägg till";
            this.cmdAddRecipe.UseVisualStyleBackColor = true;
            // 
            // cmdEditRecipe
            // 
            this.cmdEditRecipe.Location = new System.Drawing.Point(171, 432);
            this.cmdEditRecipe.Name = "cmdEditRecipe";
            this.cmdEditRecipe.Size = new System.Drawing.Size(104, 23);
            this.cmdEditRecipe.TabIndex = 7;
            this.cmdEditRecipe.Text = "Uppdatera";
            this.cmdEditRecipe.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteRecipe
            // 
            this.cmdDeleteRecipe.Location = new System.Drawing.Point(281, 432);
            this.cmdDeleteRecipe.Name = "cmdDeleteRecipe";
            this.cmdDeleteRecipe.Size = new System.Drawing.Size(98, 23);
            this.cmdDeleteRecipe.TabIndex = 8;
            this.cmdDeleteRecipe.Text = "Ta bort";
            this.cmdDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // EditDeleteRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 492);
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
    }
}