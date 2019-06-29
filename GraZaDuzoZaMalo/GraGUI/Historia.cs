using ModelGry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ModelGry.Gra;

namespace GraGUI
{
    public partial class Historia : Form
    {
        public Historia(Gra g)
        {
            InitializeComponent();
            this.g = g;
            ZaladujHistorie();
        }

        private Gra g;

        private void ZaladujHistorie()
        {
            foreach (Ruch item in g.Historia)
            {
                dataGridView1.Rows.Add(item.propozycja, item.odpowiedz, item.kiedy);
            }
        }


    }
}
