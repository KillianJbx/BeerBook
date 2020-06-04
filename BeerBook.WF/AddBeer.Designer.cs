namespace BeerBook.WF
{
    partial class AddBeer
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
            this.BeerUCPanel = new System.Windows.Forms.Panel();
            this.ValiderButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BeerUCPanel
            // 
            this.BeerUCPanel.Location = new System.Drawing.Point(59, 12);
            this.BeerUCPanel.Name = "BeerUCPanel";
            this.BeerUCPanel.Size = new System.Drawing.Size(646, 349);
            this.BeerUCPanel.TabIndex = 0;
            // 
            // ValiderButton
            // 
            this.ValiderButton.Location = new System.Drawing.Point(88, 389);
            this.ValiderButton.Name = "ValiderButton";
            this.ValiderButton.Size = new System.Drawing.Size(171, 48);
            this.ValiderButton.TabIndex = 1;
            this.ValiderButton.Text = "Valider";
            this.ValiderButton.UseVisualStyleBackColor = true;
            this.ValiderButton.Click += new System.EventHandler(this.ValiderButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Location = new System.Drawing.Point(473, 389);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(171, 48);
            this.AnnulerButton.TabIndex = 2;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // AddBeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.ValiderButton);
            this.Controls.Add(this.BeerUCPanel);
            this.Name = "AddBeer";
            this.Text = "AddBeer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BeerUCPanel;
        private System.Windows.Forms.Button ValiderButton;
        private System.Windows.Forms.Button AnnulerButton;
    }
}