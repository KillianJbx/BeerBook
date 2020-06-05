using BeerBook.BDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerBook.WF
{
    public partial class AddBeer : Form
    {
        private BeerUserControl beerUserControl;

        public AddBeer()
        {
            InitializeComponent();
            this.ValiderButton.Enabled = false;
            beerUserControl = new BeerUserControl();

            beerUserControl.Dock = DockStyle.Fill;

            this.BeerUCPanel.Controls.Add(beerUserControl);
            ((TextBox)this.beerUserControl.Controls["NomTextBox"]).TextChanged += new EventHandler(Checker);
            ((TextBox)this.beerUserControl.Controls["TauxAlcoolémieTextBox"]).TextChanged += new EventHandler(Checker);
            beerUserControl.Load_Combobox();
        }

        private void Checker(object sender, EventArgs e)
        {
            
            // le Controle de saisie ne marche que sur un à la fois, je sais c'est nul  mais j'en ai ma claque
            if (String.IsNullOrEmpty((this.beerUserControl.Controls["NomTextBox"].Text)) &&  String.IsNullOrEmpty((this.beerUserControl.Controls["TauxAlcoolémieTextBox"].Text)))
            {
                this.ValiderButton.Enabled = false;
            }
            else
            {
                this.ValiderButton.Enabled = true;
            }

        }
     
        private void ValiderButton_Click(object sender, EventArgs e)
        {
            BeerBDD beerBDD = new BeerBDD();
            Beer b = this.beerUserControl.GetBeer();

            this.DialogResult = DialogResult.OK;

            try
            {
                beerBDD.Insert(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
