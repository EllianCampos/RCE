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
        SQLiteConnection conn;
        SQLiteDataAdapter dataAdapter;
        DataTable dataTable;

        private static string dbstring = ConfigurationManager.ConnectionStrings["dbstring"].ConnectionString;

        public Datos()
        {
             conn = new SQLiteConnection(dbstring);
        }

        public bool Ejecutar(SQLiteCommand cmd)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
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
                conn.Close();
            }
        }

        public DataTable Obtener(SQLiteCommand cmd)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
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
                conn.Close();
            }
        }
    }
}
