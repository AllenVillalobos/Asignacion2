using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace Asignacion2.Conexion
{
    public class DatabaseHelper
    {
        /// <summary>
        /// Devuelve la cadena de conexión desde el archivo de configuración.
        /// </summary>
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        }

        /// <summary>
        /// Guarda los errores en un archivo de texto para revisar después.
        /// </summary>
        public void LogError(Exception ex)
        {
            string logFilePath = @"C:\Error_DB\investigacion2.log";

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} - Error: {ex.Message}");
                writer.WriteLine($"StackTrace: {ex.StackTrace}");
                writer.WriteLine();
            }
        }

        /// <summary>
        /// Ejecuta una consulta SELECT y devuelve los resultados en una tabla.
        /// </summary>
        public DataTable ExecuteSelectQuery(string query, SqlParameter[] sqlParameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (sqlParameters != null)
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddRange(sqlParameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw;
            }
        }

        /// <summary>
        /// Ejecuta una consulta INSERT, UPDATE o DELETE sin devolver datos.
        /// </summary>
        public void ExecuteQuery(string query, SqlParameter[] sqlParameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(sqlParameters);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw;
            }
        }
    }
}
