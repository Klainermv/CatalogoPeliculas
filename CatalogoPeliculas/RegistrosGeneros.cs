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
    public partial class RegistrosGeneros : Form
    {
        private Generos genero = new Generos();
        public RegistrosGeneros()
        {
            InitializeComponent();
        }

        private void Guardarbutton3_Click(object sender, EventArgs e)
        {
            //genero.Descripcion=Descripciontexbox.text; - pasar la descripcion escrita en el textbox a la clase
            //genero.insertar(); - llamar el metodo

            
        }

        private void Limpiarbutton2_Click(object sender, EventArgs e)
        {
            //Limpiar();
        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {
            //genero.GeneroId=Convert.int32(GeneroIdtextbox.tex); - convertir de string a entero
            //genero.Eliminar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
         private void Limpiar(){
         *  descripciontextbox.text="";
         * }
         
         */
    }
}
