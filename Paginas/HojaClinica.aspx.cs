using System;
using System.Collections.Generic;
using Asignacion2.Conexion;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Asignacion2.Paginas
{
    public partial class HojaClinica : System.Web.UI.Page
    {
        /// <summary>
        /// Verifica si hay sesión activa al cargar la página y llena datos de usuario y fecha.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioNombre"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                txtUsuarios.Text = Session["UsuarioNombre"].ToString();
                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtUsuario.Text = Session["UsuarioNombre"].ToString();
                txtFechaAdicion.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        /// <summary>
        /// Busca los datos de una mascota usando su ID e imprime los resultados en los campos.
        /// </summary>
        public void btnBuscar_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            try
            {
                String query = "spBuscarMascotaPorIdentificador";
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@pIdentificadorMascota", System.Data.SqlDbType.Int, 15) { Value = int.Parse(txtIDMascota.Text) }
                };
                var resultado = dbHelper.ExecuteSelectQuery(query, sqlParameters);
                if (resultado.Rows.Count >= 1)
                {
                    txtNombreMas.Text = resultado.Rows[0]["MAS_NOMBRE"].ToString();
                    txtPeso.Text = resultado.Rows[0]["MAS_PESO"].ToString();
                    txtAlergias.Text = resultado.Rows[0]["MAS_ALERGIAS"].ToString();
                    txtSexo.Text = resultado.Rows[0]["MAS_SEXO"].ToString();
                    txtFechaNacimiento.Text = Convert.ToDateTime(resultado.Rows[0]["MAS_FECHA_NACIMIENTO"]).ToString("dd/MM/yyyy");
                    txtIDMascota.Text = resultado.Rows[0]["MAS_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Mascota No Encontrada"))
                {
                    Response.Redirect("AgregarMascota.aspx");
                }
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Actualiza los datos básicos de la mascota, como peso o alergias.
        /// </summary>
        public void btnActualizar_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            try
            {
                String query = "spActualizarMascota";
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@pIdentificadorMascota", System.Data.SqlDbType.Int, 15) { Value = int.Parse(txtIDMascota.Text) },
                    new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 50) { Value = txtNombreMas.Text },
                    new SqlParameter("@pPeso", System.Data.SqlDbType.Float) { Value = double.Parse(txtPeso.Text) },
                    new SqlParameter("@pAlergias", System.Data.SqlDbType.NVarChar, 100) { Value = txtAlergias.Text },
                    new SqlParameter("@pModificadoPor", System.Data.SqlDbType.NVarChar, 10) { Value = txtUsuarios.Text },
                    new SqlParameter("@pFechaModificacion", System.Data.SqlDbType.NVarChar, 15) { Value = txtFecha.Text }
                };
                dbHelper.ExecuteQuery(query, sqlParameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Guarda una nueva hoja clínica para la mascota con síntomas, diagnóstico y tratamiento.
        /// </summary>
        public void btnGuardarHoja_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            try
            {
                String query = "spCrearHojaClinica";
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@pFechaAdiccion", System.Data.SqlDbType.NVarChar, 150) { Value = txtFechaAdicion.Text },
                    new SqlParameter("@pSintomas", System.Data.SqlDbType.NVarChar, 150) { Value = txtSintomas.Text },
                    new SqlParameter("@pDiagnostico", System.Data.SqlDbType.NVarChar, 150) { Value = txtDiagnostico.Text },
                    new SqlParameter("@pTratamiento", System.Data.SqlDbType.NVarChar, 150) { Value = txtTratamiento.Text },
                    new SqlParameter("@pIdMascota", System.Data.SqlDbType.Int) { Value = int.Parse(txtIDMascota.Text) },
                    new SqlParameter("@pAdicionadoPor", System.Data.SqlDbType.NVarChar, 150) { Value = txtUsuario.Text }
                };
                dbHelper.ExecuteQuery(query, sqlParameters);
            }
            catch (Exception ex)
            {
                txtMensaje.Text = ex.Message;
            }
        }

        /// <summary>
        /// Limpia todos los campos del formulario de hoja clínica.
        /// </summary>
        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTratamiento.Text = "";
            txtPeso.Text = "";
            txtNombreMas.Text = "";
            txtIDMascota.Text = "";
            txtSexo.Text = "";
            txtFechaNacimiento.Text = "";
            txtAlergias.Text = "";
            txtSintomas.Text = "";
            txtDiagnostico.Text = "";
        }
    }
}
