using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Data.SqlClient;

namespace DATOS
{
    public class Datos
    {
        SQLiteConnection cn;
        SQLiteDataAdapter da;
        DataTable dt;

        private static string dbstring = ConfigurationManager.ConnectionStrings["dbstring"].ConnectionString;
        SQLiteConnection conexionSQLite = new SQLiteConnection(dbstring);

        public Datos()
        {
             cn = new SQLiteConnection(dbstring);
        }

        public bool ProbarConexion()
        {
            try
            {
                conexionSQLite.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexionSQLite.Close();
            }
        }

        public bool Ejecutar(SQLiteCommand cmd)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
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
                cn.Close();
            }
        }

        public DataTable Obtener(SQLiteCommand cmd)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                da = new SQLiteDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                //return null;
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
