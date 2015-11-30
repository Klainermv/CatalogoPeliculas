using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Peliculas
    {
        public int PeliculaId { set; get; }
        public string titulo { set; get; }
        public string descripcion { set; get; }
        public int genero { set; get; }
        public string idioma { set; get; }
        public string director { set; get; }
        public int duracion { set; get; }
        public string pais { set; get; }
        public int anio { set; get; }
        public string protagonistas { set; get; }
        public int categoria { set; get; }
        private Conexion conexion = new Conexion();// para utilizarla en todos los metodos.

        public Peliculas() {
            this.PeliculaId = 0;
            this.titulo = "";
            this.descripcion = "";
            this.genero = 0;
            this.idioma = "";
            this.director = "";
            this.duracion = 0;
            this.pais = "";
            this.anio = 0;
            this.protagonistas = "";
            this.categoria = 0;
        }

        public bool Insertar()
        {
            return conexion.EjecutarDB("insert into Peliculas(titulo,descripcion,genero,idioma,director,duracion,pais,anio,protagonistas,categoria) values('"+titulo+"','"+descripcion+"','"+genero+"','"+idioma+"','"+director+"','"+duracion+"', '"+pais+"','"+anio+"','"+protagonistas+"', '"+categoria+"') ");
        }

        public bool Modificar(){
            return conexion.EjecutarDB("update Peliculas set titulo = '"+titulo+"', descripcion = '"+descripcion+"', genero = '"+genero+"', idioma = '"+director+"', duracion = '"+duracion+"', pais = '"+pais+"', anio = '"+anio+"', protagonistas = '"+protagonistas+"', categoria = '"+categoria+"' where PeliculaId ="+PeliculaId+"");
        }

        public bool Eliminar() {
            return conexion.EjecutarDB("delete from Peliculas where PeliculaId = "+PeliculaId+"");

        }

        public bool Buscar(int Id) {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("select * from Peliculas where PeliculaId = " + Id + "");
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                this.PeliculaId = (int) dt.Rows[0]["PeliculaId"];
                this.titulo = dt.Rows[0]["titulo"].ToString();
                this.descripcion = dt.Rows[0]["descripcion"].ToString();
                this.genero = (int)dt.Rows[0]["genero"];
                this.idioma = dt.Rows[0]["idioma"].ToString();
                this.director = dt.Rows[0]["director"].ToString();
                this.duracion = (int) dt.Rows[0]["duracion"];
                this.pais = dt.Rows[0]["pais"].ToString();
                this.anio = (int) dt.Rows[0]["anio"];
                this.protagonistas = dt.Rows[0]["protagonistas"].ToString();
                this.categoria = (int) dt.Rows[0]["categoria"];
            }

            return retorno;
        
        
        
        }

        public DataTable Listar(String campos, String filtrowhere) {
            return conexion.BuscarDb("select "+campos+ " from Peliculas where "+filtrowhere);
        }
    }
}
