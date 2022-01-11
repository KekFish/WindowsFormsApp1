using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacja
{

    public partial class Kasa : UserControl
    {
        public Kasa()
        {
            InitializeComponent();
        }

        
        double cena = 0;
        
        private void dodaj_cene13(object sender, EventArgs e)
        {
            cena += 13.00;
            label4.Text = $"{cena} zł";
        }

        private void dodaj_cene15(object sender, EventArgs e)
        {
            cena += 15.00;
            label4.Text = $"{cena} zł";
        }


        private void dodaj_cene10(object sender, EventArgs e)
        {
            cena += 10.00;
            label4.Text = $"{cena} zł";
        }

        private void reset(object sender, EventArgs e)
        {
            cena = 0.00;
            label4.Text = $"{cena} zł";
        }

        private void confirm(object sender, EventArgs e)
        {

        }
    }
}
