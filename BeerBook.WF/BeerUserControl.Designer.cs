using System.Windows.Forms;

namespace BeerBook.WF
{
    partial class BeerUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NomLabel = new System.Windows.Forms.Label();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CategorieLabel = new System.Windows.Forms.Label();
            this.GammeLabel = new System.Windows.Forms.Label();
            this.TauxAlcoolémieLabel = new System.Windows.Forms.Label();
            this.TauxAlcoolémieTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.CategorieComboBox = new System.Windows.Forms.ComboBox();
            this.GammeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(36, 36);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(37, 13);
            this.NomLabel.TabIndex = 0;
            this.NomLabel.Text = "Libellé";
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(188, 33);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(360, 20);
            this.NomTextBox.TabIndex = 1;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(36, 82);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(131, 13);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date de mis en production";
            // 
            // CategorieLabel
            // 
            this.CategorieLabel.AutoSize = true;
            this.CategorieLabel.Location = new System.Drawing.Point(36, 127);
            this.CategorieLabel.Name = "CategorieLabel";
            this.CategorieLabel.Size = new System.Drawing.Size(52, 13);
            this.CategorieLabel.TabIndex = 5;
            this.CategorieLabel.Text = "Catégorie";
            // 
            // GammeLabel
            // 
            this.GammeLabel.AutoSize = true;
            this.GammeLabel.Location = new System.Drawing.Point(36, 173);
            this.GammeLabel.Name = "GammeLabel";
            this.GammeLabel.Size = new System.Drawing.Size(77, 13);
            this.GammeLabel.TabIndex = 6;
            this.GammeLabel.Text = "Gamme de prix";
            // 
            // TauxAlcoolémieLabel
            // 
            this.TauxAlcoolémieLabel.AutoSize = true;
            this.TauxAlcoolémieLabel.Location = new System.Drawing.Point(36, 218);
            this.TauxAlcoolémieLabel.Name = "TauxAlcoolémieLabel";
            this.TauxAlcoolémieLabel.Size = new System.Drawing.Size(84, 13);
            this.TauxAlcoolémieLabel.TabIndex = 8;
            this.TauxAlcoolémieLabel.Text = "Taux alcoolémie";
            // 
            // TauxAlcoolémieTextBox
            // 
            this.TauxAlcoolémieTextBox.Location = new System.Drawing.Point(188, 215);
            this.TauxAlcoolémieTextBox.Name = "TauxAlcoolémieTextBox";
            this.TauxAlcoolémieTextBox.Size = new System.Drawing.Size(360, 20);
            this.TauxAlcoolémieTextBox.TabIndex = 9;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(36, 260);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 10;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(188, 257);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(360, 96);
            this.DescriptionRichTextBox.TabIndex = 11;
            this.DescriptionRichTextBox.Text = "";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(188, 79);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(360, 20);
            this.DateTextBox.TabIndex = 12;
            // 
            // CategorieComboBox
            // 
            this.CategorieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorieComboBox.FormattingEnabled = true;
            this.CategorieComboBox.Location = new System.Drawing.Point(188, 124);
            this.CategorieComboBox.Name = "CategorieComboBox";
            this.CategorieComboBox.Size = new System.Drawing.Size(360, 21);
            this.CategorieComboBox.TabIndex = 13;
            this.CategorieComboBox.SelectedIndexChanged += new System.EventHandler(this.CategorieComboBox_SelectedIndexChanged);
            // 
            // GammeComboBox
            // 
            this.GammeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GammeComboBox.FormattingEnabled = true;
            this.GammeComboBox.Location = new System.Drawing.Point(188, 170);
            this.GammeComboBox.Name = "GammeComboBox";
            this.GammeComboBox.Size = new System.Drawing.Size(360, 21);
            this.GammeComboBox.TabIndex = 14;
            this.GammeComboBox.SelectedIndexChanged += new System.EventHandler(this.GammeComboBox_SelectedIndexChanged);
            // 
            // BeerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.GammeComboBox);
            this.Controls.Add(this.CategorieComboBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TauxAlcoolémieTextBox);
            this.Controls.Add(this.TauxAlcoolémieLabel);
            this.Controls.Add(this.GammeLabel);
            this.Controls.Add(this.CategorieLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NomTextBox);
            this.Controls.Add(this.NomLabel);
            this.Name = "BeerUserControl";
            this.Size = new System.Drawing.Size(584, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CategorieLabel;
        private System.Windows.Forms.Label GammeLabel;
        private System.Windows.Forms.Label TauxAlcoolémieLabel;
        private System.Windows.Forms.TextBox TauxAlcoolémieTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.ComboBox CategorieComboBox;
        private System.Windows.Forms.ComboBox GammeComboBox;
    }
}
