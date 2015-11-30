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
    public partial class RegistroPeliculas : Form
    {
        private Peliculas peliculas = new Peliculas();
        private Generos genero = new Generos();
        private Categorias categoria = new Categorias();
        public RegistroPeliculas()
        {
            InitializeComponent();
            generocomboBox.DataSource = genero.Listar("*","1=1");
            generocomboBox.DisplayMember = "descripcion";
            generocomboBox.ValueMember = "GeneroId";

            categoriacomboBox.DataSource = categoria.Listar("*","1=1");
            categoriacomboBox.DisplayMember = "descripcion";
            categoriacomboBox.ValueMember = "CategoriaId";
        }


        private void Limpiar() {
            PeliculaIdtextBox.Clear();
            titulotextBox.Clear();
            descripciontextBox.Clear();
            idiomatextBox.Clear();
            duraciontextBox.Clear();
            directortextBox.Clear();
            paistextBox.Clear();
            aniotextBox.Clear();
            protagonistatextBox.Clear();

        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton3_Click(object sender, EventArgs e)
        {
            peliculas.titulo = titulotextBox.Text;
            peliculas.descripcion = descripciontextBox.Text;
            peliculas.genero = Convert.ToInt32(generocomboBox.SelectedValue);
            peliculas.idioma = idiomatextBox.Text;
            peliculas.director = directortextBox.Text;
            peliculas.pais = paistextBox.Text;
            peliculas.duracion = Convert.ToInt32(duraciontextBox.Text);
            peliculas.anio = Convert.ToInt32(aniotextBox.Text);
            peliculas.protagonistas = protagonistatextBox.Text;
            peliculas.categoria = Convert.ToInt32(categoriacomboBox.SelectedValue);
            peliculas.Insertar();

            Limpiar();
        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {
            peliculas.PeliculaId = Convert.ToInt32(PeliculaIdtextBox.Text);
            peliculas.Eliminar();
            Limpiar();
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            peliculas.Buscar(Convert.ToInt32(PeliculaIdtextBox.Text));
            titulotextBox.Text = peliculas.titulo;
            descripciontextBox.Text = peliculas.descripcion;
            idiomatextBox.Text = peliculas.idioma;
            directortextBox.Text = peliculas.director;
            duraciontextBox.Text = peliculas.duracion.ToString();
            paistextBox.Text = peliculas.pais;
            aniotextBox.Text = peliculas.anio.ToString();
            protagonistatextBox.Text = peliculas.protagonistas;
            generocomboBox.SelectedValue = peliculas.genero;
            categoriacomboBox.SelectedValue = peliculas.categoria;

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            peliculas.PeliculaId = Convert.ToInt32(PeliculaIdtextBox.Text);
            peliculas.titulo = titulotextBox.Text;
            peliculas.descripcion = descripciontextBox.Text;
            peliculas.genero = Convert.ToInt32(generocomboBox.SelectedValue);
            peliculas.idioma = idiomatextBox.Text;
            peliculas.director = directortextBox.Text;
            peliculas.pais = paistextBox.Text;
            peliculas.duracion = Convert.ToInt32(duraciontextBox.Text);
            peliculas.anio = Convert.ToInt32(aniotextBox.Text);
            peliculas.protagonistas = protagonistatextBox.Text;
            peliculas.categoria = Convert.ToInt32(categoriacomboBox.SelectedValue);
            peliculas.Modificar();

            Limpiar();
        }
    }
}
