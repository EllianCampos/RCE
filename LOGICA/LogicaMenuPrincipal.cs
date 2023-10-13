using DATOS;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class LogicaMenuPrincipal
    {
        Datos datos = new Datos();
        SQLiteCommand cmd;

        public DataTable Test()
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT * from Test;";
            DataTable dt = datos.Obtener(cmd);
            return dt;
        }
    }

    
}
