using System;
using Asignacion2.Conexion;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Asignacion2.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnIngresar_Click(object sender, EventArgs e)
        {
            
            DatabaseHelper dbHelper = new DatabaseHelper();
            try
            {
                String query = "spLogin";
                SqlParameter[] sqlParameters = new SqlParameter[] { 
                new SqlParameter("@pNombreUsuario",System.Data.SqlDbType.NVarChar,15){Value = txtNombre.Text},
                new SqlParameter("@pContra", System.Data.SqlDbType.NVarChar,10){Value=txtContra.Text}
                };
                var resultado = dbHelper.ExecuteSelectQuery(query, sqlParameters);

                if (resultado.Rows.Count>= 1)
                {
                    Session["UsuarioNombre"] = txtNombre.Text;
                    Response.Redirect("HojaClinica.aspx");
                }
                else
                {
                    lblMensaje.Text = "Usuario o contraseña incorrectos.";
                }
            }
            catch(Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}