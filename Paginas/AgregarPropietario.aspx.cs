using System;
using Asignacion2.Conexion;
using System.Data.SqlClient;
using System.Web.UI;

namespace Asignacion2.Paginas
{
    public partial class AgregarPropietario : System.Web.UI.Page
    {
        /// <summary>
        /// Carga inicial de la página. Verifica sesión activa y configura campos de usuario
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioNombre"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                txtUsuario.Text = Session["UsuarioNombre"].ToString();
                txtFechaAdicion.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtUsuarios.Text = Session["UsuarioNombre"].ToString();
            }
        }

        /// <summary>
        /// Guarda un nuevo propietario en la base de datos usando datos del formulario
        /// </summary>
        public void btnGuardarDueño_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            try
            {
                string query = "spInsertarPropietario";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@pNumeroIdentificacion", System.Data.SqlDbType.NVarChar,15){Value = txtIdentificacion.Text},
                    new SqlParameter("@pPrimerNombre", System.Data.SqlDbType.NVarChar,25) {Value = txtNombreDueño1.Text},
                    new SqlParameter("@pSegundoNombre", System.Data.SqlDbType.NVarChar,25) {Value = txtNombreDueño2.Text},
                    new SqlParameter("@pPrimerApellido", System.Data.SqlDbType.NVarChar,25) {Value = txtApellidoDueño1.Text},
                    new SqlParameter("@pSegundoApellido", System.Data.SqlDbType.NVarChar,25) {Value = txtApellidoDueño2.Text},
                    new SqlParameter("@pTelefonoCelular", System.Data.SqlDbType.NVarChar,25) {Value = txtTelefonoDueño.Text},
                    new SqlParameter("@pCorreoElectronico",System.Data.SqlDbType.NVarChar,25) {Value = txtEmailDueño.Text},
                    new SqlParameter("@pAdicionadoPor", System.Data.SqlDbType.NVarChar,25) {Value = txtUsuario.Text},
                    new SqlParameter("@pFechaAdicion", System.Data.SqlDbType.NVarChar,25) {Value = txtFechaAdicion.Text}
                };
                db.ExecuteSelectQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el propietario: " + ex.Message);
            }
        }

        /// <summary>
        /// Limpia todos los campos del formulario para ingresar nuevos datos
        /// </summary>
        public void btnLimiar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "";
            txtNombreDueño1.Text = "";
            txtNombreDueño2.Text = "";
            txtApellidoDueño1.Text = "";
            txtApellidoDueño2.Text = "";
            txtEmailDueño.Text = "";
            txtTelefonoDueño.Text = "";
        }
    }
}
