using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace DATOS
{
    public class Datos
    {
        SQLiteConnection conexion111;
        SQLiteDataAdapter dataAdapter;
        DataTable dataTable;

        private static string dbstring = ConfigurationManager.ConnectionStrings["dbstring"].ConnectionString;

        public Datos()
        {
             conexion111 = new SQLiteConnection(dbstring);
        }

        public bool Ejecutar(SQLiteCommand cmd)
        {
            try
            {
                conexion111.Open();
                cmd.Connection = conexion111;
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0) return true; else return false;
            }
            catch (Exception)
            {
                //return false;
                throw;
            }
            finally
            {
                conexion111.Close();
            }
        }

        public DataTable Obtener(SQLiteCommand cmd)
        {
            try
            {
                conexion111.Open();
                cmd.Connection = conexion111;
                dataAdapter = new SQLiteDataAdapter(cmd);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception)
            {
                //return null;
                throw;
            }
            finally
            {
                conexion111.Close();
            }
        }
    }
}
