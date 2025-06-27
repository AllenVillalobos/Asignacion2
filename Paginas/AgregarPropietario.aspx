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

           <asp:Label runat="server">Usuario Conectado</asp:Label><br />
 <asp:TextBox ReadOnly="true" ID="txtUsuarios" runat="server"></asp:TextBox>

       <h2 class="page-title">Registrar / Editar Dueño</h2>

             <label for="txtIdentificacion">Identificacion</label>
        <asp:TextBox ID="txtIdentificacion" runat="server"
                     CssClass="form-control"
                     Placeholder="Identificacion" />


        <label for="txtNombreDueño1">Primer Nombre</label>
        <asp:TextBox ID="txtNombreDueño1" runat="server"
                     CssClass="form-control"
                     Placeholder="Primer Nombre" />

            <label for="txtNombreDueño2">Segundo Nombre</label>
       <asp:TextBox ID="txtNombreDueño2" runat="server"
                    CssClass="form-control"
                    Placeholder="Segundo Nombre" />

                      <label for="txtApellidoDueño1">Primer Apellido</label>
       <asp:TextBox ID="txtApellidoDueño1" runat="server"
                    CssClass="form-control"
                    Placeholder="Primer Apellido" />

                 <label for="txtApellidoDueño2">Segundo Apellido</label>
       <asp:TextBox ID="txtApellidoDueño2" runat="server"
                    CssClass="form-control"
                    Placeholder="Segundo Apellido" />


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

             <asp:Button ID="btnLimiar" runat="server"
                    Text="Limpiar"
                    CssClass="btn-primary"
                    OnClick="btnLimiar_Click" />

        <asp:Label ID="lblMensaje" runat="server"
                   CssClass="error-msg" />
      </div>
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
