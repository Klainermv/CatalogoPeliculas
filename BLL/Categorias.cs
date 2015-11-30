using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Categorias
    {
        public DataTable Listar(String campos, String filtrowhere) { 
            Conexion conexion = new Conexion();
            return conexion.BuscarDb("select "+campos+" from Categorias where "+filtrowhere);
        }
    }
}
