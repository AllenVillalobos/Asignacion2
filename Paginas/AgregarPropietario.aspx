<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPropietario.aspx.cs" Inherits="Asignacion2.Paginas.AgregarPropietario" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Registrar / Editar Dueño</title>
  <link rel="stylesheet" href="~/Estilos/main.css" />
</head>
<body>
  <form id="form1" runat="server">
    <div class="clinica-container">
      <div class="gradient-card">
        
        <h2 class="page-title">Registrar / Editar Dueño</h2>

        <label for="txtNombreDueño">Nombre</label>
        <asp:TextBox ID="txtNombreDueño" runat="server"
                     CssClass="form-control"
                     Placeholder="Nombre completo" />

        <label for="txtTelefonoDueño">Teléfono</label>
        <asp:TextBox ID="txtTelefonoDueño" runat="server"
                     CssClass="form-control"
                     Placeholder="1234-5678" />

        <label for="txtEmailDueño">Correo electrónico</label>
        <asp:TextBox ID="txtEmailDueño" runat="server"
                     CssClass="form-control"
                     Placeholder="correo@ejemplo.com" />

        <asp:Button ID="btnGuardarDueño" runat="server"
                    Text="Guardar Dueño"
                    CssClass="btn-primary"
                    OnClick="btnGuardarDueño_Click" />

        <asp:Label ID="lblMensaje" runat="server"
                   CssClass="error-msg" />
      </div>
    </div>
  </form>
</body>
</html>
