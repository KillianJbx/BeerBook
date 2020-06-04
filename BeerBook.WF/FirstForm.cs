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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void BeersButton_Click(object sender, EventArgs e)
        {
            BeerForm form = new BeerForm();
            form.ShowDialog();
        }
    }
}
