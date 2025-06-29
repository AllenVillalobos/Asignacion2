using Asignacion2.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asignacion2.Paginas
{
    public partial class AgregarMascota : System.Web.UI.Page
    {
        /// <summary>
        /// Carga inicial de la página. Verifica si hay sesión iniciada y configura controles.
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
                ddlSexo.Items.Clear();
                ddlSexo.Items.Add(new ListItem("Macho", "M"));
                ddlSexo.Items.Add(new ListItem("Hembra", "H"));
            }
        }

        /// <summary>
        /// Busca los datos del propietario según su identificación. Si no existe, redirige para agregarlo.
        /// </summary>
        public void btnBuscarPropietario_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            try
            {
                string query = "spConsultarPopietario";
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@pNumeroIdentificacion", System.Data.SqlDbType.NVarChar, 15) { Value = txtPropietarioIdentificacion.Text }
                };
                var resultado = dbHelper.ExecuteSelectQuery(query, sqlParameters);
                if (resultado.Rows.Count >= 1)
                {
                    txtPropietarioNombre.Text = resultado.Rows[0]["PRO_PRIMER_NOMBRE"].ToString();
                    txtApellido1.Text = resultado.Rows[0]["PRO_PRIMER_APELLIDO"].ToString();
                    txtApellido2.Text = resultado.Rows[0]["PRO_SEGUNDO_APELLIDO"].ToString();
                    txtCelular.Text = resultado.Rows[0]["PRO_TELEFONO"].ToString();
                    txtCorreo.Text = resultado.Rows[0]["PRO_CORREO"].ToString();
                    txtPropietarioIdentificacion.Text = resultado.Rows[0]["PRO_IDENTIFICACION"].ToString();
                }
                else
                {
                    Response.Redirect("AgregarPropietario.aspx");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Propietario No Encontrado"))
                {
                    Response.Redirect("AgregarPropietario.aspx");
                }
                else
                {
                    Console.Write(ex.Message);
                }
            }
        }

        /// <summary>
        /// Redirige a la página para agregar un nuevo propietario.
        /// </summary>
        public void btnAgregarPropietario_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarPropietario.aspx");
        }

        /// <summary>
        /// Actualiza los datos del propietario en la base de datos.
        /// </summary>
        public void btnActualizar_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            try
            {
                string query = "spActualizarPropietario";
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@pNumeroIdentificacion", System.Data.SqlDbType.NVarChar, 15) { Value = txtPropietarioIdentificacion.Text },
                    new SqlParameter("@pPrimerNombre", System.Data.SqlDbType.NVarChar, 25) { Value = txtPropietarioNombre.Text },
                    new SqlParameter("@pPrimerApellido", System.Data.SqlDbType.NVarChar, 25) { Value = txtApellido1.Text },
                    new SqlParameter("@pSegundoApellido", System.Data.SqlDbType.NVarChar, 25) { Value = txtApellido2.Text },
                    new SqlParameter("@pTelefonoCelular", System.Data.SqlDbType.NVarChar, 8) { Value = txtCelular.Text },
                    new SqlParameter("@pCorreoElectronico", System.Data.SqlDbType.NVarChar, 150) { Value = txtCorreo.Text },
                    new SqlParameter("@pModificadoPor", System.Data.SqlDbType.NVarChar, 15) { Value = txtUsuario.Text },
                    new SqlParameter("@pFechaModificacion", System.Data.SqlDbType.NVarChar, 50) { Value = txtFechaAdicion.Text }
                };
                dbHelper.ExecuteQuery(query, sqlParameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Guarda una nueva mascota asociada al propietario encontrado. 
        /// Si no hay propietario, redirige para agregar uno.
        /// </summary>
        public void btnGuardarMascota_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            try
            {
                int IDPropietario = 0;
                string query1 = "spConsultarPopietario";
                SqlParameter[] sqlParameters1 = new SqlParameter[] {
                    new SqlParameter("@pNumeroIdentificacion", System.Data.SqlDbType.NVarChar, 15) { Value = txtPropietarioIdentificacion.Text }
                };
                var resultado = dbHelper.ExecuteSelectQuery(query1, sqlParameters1);
                if (resultado.Rows.Count >= 1)
                {
                    IDPropietario = int.Parse(resultado.Rows[0]["PRO_ID"].ToString());
                    string query2 = "spInsertarMascota";
                    SqlParameter[] sqlParameters2 = new SqlParameter[] {
                        new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 15) { Value = txtNombreMascota.Text },
                        new SqlParameter("@pFechaNacimiento", System.Data.SqlDbType.NVarChar, 50) { Value = cldFechaNacimiento.SelectedDate.ToString("dd/MM/yyyy") },
                        new SqlParameter("@pSexo", System.Data.SqlDbType.Char, 1) { Value = ddlSexo.SelectedValue.ToString()},
                        new SqlParameter("@pPeso", System.Data.SqlDbType.Int) { Value = int.Parse(txtPesoMascota.Text) },
                        new SqlParameter("@pAlergias", System.Data.SqlDbType.NVarChar, 150) { Value = txtAlergiasMascota.Text },
                        new SqlParameter("@pIdentificadorPropietario", System.Data.SqlDbType.Int) { Value = IDPropietario },
                        new SqlParameter("@pAdicionadoPor", System.Data.SqlDbType.NVarChar, 15) { Value = txtUsuario.Text },
                        new SqlParameter("@pFechaAdicion", System.Data.SqlDbType.NVarChar, 50) { Value = txtFechaAdicion.Text }
                    };
                    dbHelper.ExecuteQuery(query2, sqlParameters2);
                }
                else
                {
                    Response.Redirect("AgregarPropietario.aspx");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Limpia todos los campos del formulario para ingresar nueva información.
        /// </summary>
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPropietarioIdentificacion.Text = "";
            txtPropietarioNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtCorreo.Text = "";
            txtCelular.Text = "";

            txtNombreMascota.Text = "";
            txtPesoMascota.Text = "";
            ddlSexo.ClearSelection();
            txtAlergiasMascota.Text = "";

            lblMensajeMascota.Text = "";

            cldFechaNacimiento.SelectedDate = DateTime.Today;
            cldFechaNacimiento.VisibleDate = DateTime.Today;
        }
    }
}
