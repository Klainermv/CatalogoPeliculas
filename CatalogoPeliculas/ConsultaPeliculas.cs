using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace CatalogoPeliculas
{
    public partial class ConsultaPeliculas : Form
    {
        private Peliculas pelicula = new Peliculas();
        public ConsultaPeliculas()
        {
            InitializeComponent();
            PeliculasdataGridView.DataSource =(DataTable) pelicula.Listar("*","1=1");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string busqueda = "";
            DataTable dt = new DataTable();
            if (BuscarcomboBox.SelectedIndex==0) {

                busqueda = "PeliculaId = '"+BuscartextBox.Text+"'";
            }
            else if (BuscarcomboBox.SelectedIndex == 1)
            {

                busqueda = "titulo = '" + BuscartextBox.Text+"'";
            }

            else if (BuscarcomboBox.SelectedIndex==2) {

                busqueda = "director = '"+BuscartextBox.Text+"'";
            }

            else if (BuscarcomboBox.SelectedIndex == 3)
            {

                busqueda = "idioma = '" + BuscartextBox.Text+"'";
            }

            dt = pelicula.Listar("*",busqueda);
            PeliculasdataGridView.DataSource = dt;

        }

        private void Imprimirbutton1_Click(object sender, EventArgs e)
        {
            VisorReportes visor = new VisorReportes();
            Reportes.ReportePeliculas rp = new Reportes.ReportePeliculas();
            visor.visorcrystalReportViewer1.ReportSource = rp;
            visor.ShowDialog();
        }

     
    }
}
