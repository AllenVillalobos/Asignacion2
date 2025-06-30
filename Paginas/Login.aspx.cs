using System;
using Asignacion2.Conexion;
using System.Web.UI;
using System.Data.SqlClient;

namespace Asignacion2.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// Evento que se ejecuta al cargar la página. Actualmente no realiza ninguna acción
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            // No se requiere lógica al cargar la página por ahora
        }

        /// <summary>
        /// Valida las credenciales ingresadas por el usuario
        /// Si son correctas, se guarda el nombre en la sesión y se redirige a HojaClinica.aspx
        /// Si son incorrectas, muestra un mensaje de error
        /// </summary>
        public void btnIngresar_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            try
            {
                string query = "spLogin";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@pNombreUsuario", System.Data.SqlDbType.NVarChar, 15) { Value = txtNombre.Text },
                    new SqlParameter("@pContra", System.Data.SqlDbType.NVarChar, 10) { Value = txtContra.Text }
                };

                var resultado = dbHelper.ExecuteSelectQuery(query, sqlParameters);

                if (resultado.Rows.Count >= 1)
                {
                    // Si las credenciales son válidas, se guarda el nombre de usuario en sesión
                    Session["UsuarioNombre"] = txtNombre.Text;
                    Response.Redirect("HojaClinica.aspx");
                }
                else
                {
                    // Si las credenciales no coinciden, se muestra un mensaje
                    lblMensaje.Text = "Usuario o contraseña incorrectos.";
                }
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error si ocurre una excepción
                lblMensaje.Text = ex.Message;
            }
        }
    }
}
