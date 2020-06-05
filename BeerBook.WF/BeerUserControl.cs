using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeerBook.BDD;

namespace BeerBook.WF
{
    public partial class BeerUserControl : UserControl
    {
       
        int CatID;
        int GamID;

        public BeerUserControl()
        {
            InitializeComponent();
        }

        public void Load_Combobox()
        {
            //Fonctionne qui remplie les listes déroulantes avec les valeurs de la BDD pour Categorie et Gamme
            GammeBDD gammeBDD = new GammeBDD();
            List<Gamme> gammes = gammeBDD.GetAll();
            foreach (Gamme g in gammes)
            {
                GammeComboBox.Items.Add(g.Libelle);
            }
            CategorieBDD categorieBDD = new CategorieBDD();
            List<Categorie> categories = categorieBDD.GetAll();
            foreach (Categorie c in categories)
            {
                CategorieComboBox.Items.Add(c.Libelle);
            }
        }

        public void SetBeer(Beer b)
        {
           
            this.NomTextBox.Text = b.Libelle;
            this.DateTextBox.Text = b.DateProduction.ToString();
            this.CategorieComboBox.SelectedIndex = b.IdentifiantCategorie-1;
            this.GammeComboBox.SelectedIndex = b.IdentifiantGamme-1;
            this.TauxAlcoolémieTextBox.Text = b.TauxAlcoolemie.ToString();
            this.DescriptionRichTextBox.Text = b.Commentaire;
        }

        

        public Beer GetBeer()
        {

            Beer b = new Beer();
            b.Libelle = this.NomTextBox.Text;
            if (this.DateTextBox.Text == "")
            {
                b.DateProduction = null;
            }
            else
            {
                b.DateProduction = int.Parse(this.DateTextBox.Text);
            }

            b.IdentifiantGamme = GamID;
            b.IdentifiantCategorie = CatID;
            b.TauxAlcoolemie = float.Parse(this.TauxAlcoolémieTextBox.Text) ;
            b.Commentaire = this.DescriptionRichTextBox.Text ;

            return b;
        }

        private void CategorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           CatID = CategorieComboBox.SelectedIndex + 1;
        }

        private void GammeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            GamID = GammeComboBox.SelectedIndex + 1;
        }
    }
}
