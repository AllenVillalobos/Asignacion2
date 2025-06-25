<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HojaClinica.aspx.cs" Inherits="Asignacion2.Paginas.HojaClinica" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Historial Clínico</title>
  <!-- Enlaza tus estilos -->
  <link rel="stylesheet" href="~/Estilos/main.css" />
</head>
<body>
  <form id="form1" runat="server">
    <div class="clinica-container">

      <!-- Usuario y Fecha -->
      <div class="gradient-card">
        <asp:Label runat="server">Usuario Conectado</asp:Label><br />
        <asp:TextBox ReadOnly="true" ID="txtUsuarios" runat="server"
                     CssClass="form-control" /><br /><br />

        <asp:Label runat="server">Fecha de Atención:</asp:Label><br />
        <asp:TextBox ReadOnly="true" ID="txtFecha" runat="server"
                     CssClass="form-control" />
      </div>

      <!-- Identificador y Datos Básicos -->
      <div class="gradient-card">
        <asp:Label>Identificador de Mascotas</asp:Label><br />
        <asp:TextBox ID="txtIDMascota" runat="server"
                     CssClass="form-control" /><br /><br />

        <asp:Button Text="Agregar" runat="server" ID="bntAgregar"
                    CssClass="btn-primary"
                    PostBackUrl="~/Paginas/AgregarMascota.aspx" />
        <asp:Button Text="Buscar" runat="server" ID="btnBuscar"
                    OnClick="btnBuscar_Click"
                    CssClass="btn-primary" /><br /><br />

        <asp:Label>Nombre de la Mascota</asp:Label><br />
        <asp:TextBox ID="txtNombreMas" runat="server"
                     CssClass="form-control"
                     ReadOnly="true" /><br />

        <asp:Label>Peso Mascota (kg)</asp:Label><br />
        <asp:TextBox ID="txtPeso" runat="server"
                     CssClass="form-control"
                     ReadOnly="true" /><br />

        <asp:Label>Sexo</asp:Label><br />
        <asp:TextBox ID="txtSexo" runat="server"
                     CssClass="form-control"
                     ReadOnly="true" /><br />

        <asp:Label>Fecha de Nacimiento</asp:Label><br />
        <asp:TextBox ID="txtFechaNacimiento" runat="server"
                     CssClass="form-control"
                     ReadOnly="true" /><br /><br />

        <asp:Label>Alergias</asp:Label><br />
        <asp:TextBox TextMode="MultiLine" Rows="3" runat="server"
                     ID="txtAlergias"
                     CssClass="form-control" /><br />

        <asp:Button Text="Actualizar Datos" runat="server"
                    ID="btnActualizar"
                    OnClick="btnActualizar_Click"
                    CssClass="btn-primary" />
      </div>

      <!-- Síntomas, Diagnóstico y Tratamiento -->
      <div class="gradient-card">
        <asp:Label>Síntomas:</asp:Label><br />
        <asp:TextBox TextMode="MultiLine" Rows="5" runat="server"
                     ID="txtSintomas"
                     CssClass="form-control" /><br />

        <asp:Label>Diagnóstico:</asp:Label><br />
        <asp:TextBox TextMode="MultiLine" Rows="5" runat="server"
                     ID="TextBox1"
                     CssClass="form-control" /><br />

        <asp:Label>Tratamiento:</asp:Label><br />
        <asp:TextBox TextMode="MultiLine" Rows="5" runat="server"
                     ID="TextBox2"
                     CssClass="form-control" /><br />

        <asp:Button runat="server" Text="Limpiar Campos" ID="btnLimpiar"
                    CssClass="btn-primary" />
        <asp:Button runat="server" Text="GuardarHoja" ID="btnGuardarHoja"
                    CssClass="btn-primary" />
      </div>

      <!-- Auditoría -->
      <div class="gradient-card">
        <asp:Label>Adicionado Por</asp:Label><br />
        <asp:TextBox ReadOnly="true" ID="txtUsuario" runat="server"
                     CssClass="form-control" /><br />

        <asp:Label>Fecha de Adición</asp:Label><br />
        <asp:TextBox ReadOnly="true" ID="txtFechaAdicion" runat="server"
                     CssClass="form-control" /><br />

        <asp:Label>Modificado Por</asp:Label><br />
        <asp:TextBox ReadOnly="true" ID="txtModificadoPor" runat="server"
                     CssClass="form-control" /><br />

        <asp:Label>Fecha de Modificación</asp:Label><br />
        <asp:TextBox ReadOnly="true" ID="txtFechaModificacion" runat="server"
                     CssClass="form-control" />
      </div>

    </div>
  </form>
</body>
</html>

