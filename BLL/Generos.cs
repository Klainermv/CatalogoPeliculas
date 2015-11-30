using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Generos
    {
        public DataTable Listar(String campo, String filtrowhere) {//*,1=1
            Conexion conexion = new Conexion();
            return conexion.BuscarDb("select "+campo+" from Generos where "+filtrowhere );
        }
    }
}
