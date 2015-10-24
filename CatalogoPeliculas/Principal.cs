using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CatalogoPeliculas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPeliculas rp = new RegistroPeliculas();
            rp.Show();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosGeneros rg = new RegistrosGeneros();
            rg.Show(); 
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosCategorias rc = new RegistrosCategorias();
            rc.Show(); 
        }

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaPeliculas consulta = new ConsultaPeliculas();
            consulta.Show();
        }
    }
}
