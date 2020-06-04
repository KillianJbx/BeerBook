namespace BeerBook.WF
{
    partial class BeerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AjoutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BeerUCPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ModifierButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.BeerListBox = new System.Windows.Forms.ListBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AjoutButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BeerListBox);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 508);
            this.panel1.TabIndex = 0;
            // 
            // AjoutButton
            // 
            this.AjoutButton.Location = new System.Drawing.Point(0, 399);
            this.AjoutButton.Name = "AjoutButton";
            this.AjoutButton.Size = new System.Drawing.Size(200, 103);
            this.AjoutButton.TabIndex = 1;
            this.AjoutButton.Text = "Ajouter";
            this.AjoutButton.UseVisualStyleBackColor = true;
            this.AjoutButton.Click += new System.EventHandler(this.AjoutButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelID);
            this.panel2.Controls.Add(this.BeerUCPanel);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.ModifierButton);
            this.panel2.Controls.Add(this.IDLabel);
            this.panel2.Location = new System.Drawing.Point(195, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 503);
            this.panel2.TabIndex = 1;
            // 
            // BeerUCPanel
            // 
            this.BeerUCPanel.Location = new System.Drawing.Point(16, 61);
            this.BeerUCPanel.Name = "BeerUCPanel";
            this.BeerUCPanel.Size = new System.Drawing.Size(581, 331);
            this.BeerUCPanel.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(345, 429);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(161, 50);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Supprimer";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ModifierButton
            // 
            this.ModifierButton.Location = new System.Drawing.Point(122, 429);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(161, 50);
            this.ModifierButton.TabIndex = 2;
            this.ModifierButton.Text = "Modifier";
            this.ModifierButton.UseVisualStyleBackColor = true;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(280, 28);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(35, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "label1";
            // 
            // BeerListBox
            // 
            this.BeerListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BeerListBox.FormattingEnabled = true;
            this.BeerListBox.Location = new System.Drawing.Point(0, 0);
            this.BeerListBox.Name = "BeerListBox";
            this.BeerListBox.Size = new System.Drawing.Size(200, 394);
            this.BeerListBox.TabIndex = 0;
            this.BeerListBox.SelectedIndexChanged += new System.EventHandler(this.BeerListBox_SelectedIndexChanged);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(185, 27);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(53, 13);
            this.LabelID.TabIndex = 5;
            this.LabelID.Text = "Identifiant";
            // 
            // BeerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(802, 510);
            this.Controls.Add(this.panel1);
            this.Name = "BeerForm";
            this.Text = "BeerForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AjoutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox BeerListBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button ModifierButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel BeerUCPanel;
        private System.Windows.Forms.Label LabelID;
    }
}