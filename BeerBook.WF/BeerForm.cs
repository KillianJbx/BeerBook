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
    public partial class BeerForm : Form
    {
        private BeerUserControl beerUserControl;

        public BeerForm()
        {
            InitializeComponent();
            beerUserControl = new BeerUserControl();
            beerUserControl.Load_Combobox();
            beerUserControl.Dock = DockStyle.Fill;

            this.BeerUCPanel.Controls.Add(beerUserControl);

            RefreshBeerListBox();
        }

        private void RefreshBeerListBox()
        {

            int index = this.BeerListBox.SelectedIndex;

            BeerBDD beerBDD = new BeerBDD();
            List<Beer> beers = beerBDD.GetAll();

            this.BeerListBox.ValueMember = "Identifiant";
            this.BeerListBox.DisplayMember = "Libelle";

            this.BeerListBox.DataSource = beers;


            if (index < beers.Count - 1 && index != -1)
            {
                this.BeerListBox.SelectedIndex = index;
            }


        }
        private void BeerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Beer b = (Beer)this.BeerListBox.SelectedItem;


            this.IDLabel.Text = b.Identifiant.ToString();
            this.beerUserControl.SetBeer(b);


        }

        private void ModifierButton_Click(object sender, EventArgs e)
        {
            Beer b = beerUserControl.GetBeer();
            b.Identifiant = Int32.Parse(this.IDLabel.Text);

            BeerBDD contactBDD = new BeerBDD();
            bool nbLignes = contactBDD.Update(b);



            if (nbLignes)
            {
                this.RefreshBeerListBox();
            }
        }

        private void AjoutButton_Click(object sender, EventArgs e)
        {
            AddBeer form = new AddBeer();
            DialogResult d = form.ShowDialog();
            if (d == DialogResult.OK)
            {
                this.RefreshBeerListBox();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            BeerBDD beerBDD = new BeerBDD();

            DialogResult d = MessageBox.Show("Etes vous sur de supprimer ?", "Supression", MessageBoxButtons.YesNo);

            if (d == DialogResult.Yes)
            {
               beerBDD.Delete(int.Parse(this.IDLabel.Text));
                this.RefreshBeerListBox();

            }
        }

    }
}
