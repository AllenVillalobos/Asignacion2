<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarMascota.aspx.cs" Inherits="Asignacion2.Paginas.AgregarMascota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Agregar Mascota</title>
  <link rel="stylesheet" href="~/Estilos/main.css" />
</head>
<body>
  <form id="form1" runat="server">
    <div class="clinica-container">
      <div class="gradient-card">
        <h2 class="page-title">Agregar Mascota</h2>

        <label for="ddlPropietarios">Dueño</label>
        <asp:DropDownList ID="ddlPropietarios" runat="server"
                          CssClass="form-control" />

        <label for="txtNombreMascota">Nombre Mascota</label>
        <asp:TextBox ID="txtNombreMascota" runat="server"
                     CssClass="form-control"
                     Placeholder="Nombre de la mascota" />

        <label for="txtPesoMascota">Peso (kg)</label>
        <asp:TextBox ID="txtPesoMascota" runat="server"
                     CssClass="form-control"
                     Placeholder="Peso de la mascota" />

        <label for="txtAlergiasMascota">Alergias</label>
        <asp:TextBox ID="txtAlergiasMascota" runat="server"
                     CssClass="form-control"
                     TextMode="MultiLine" Rows="3"
                     Placeholder="Alergias conocidas" />

        <asp:Button ID="btnGuardarMascota" runat="server"
                    Text="Guardar Mascota"
                    CssClass="btn-primary"
                    OnClick="btnGuardarMascota_Click" />

        <asp:Label ID="lblMensajeMascota" runat="server"
                   CssClass="error-msg" />
      </div>
    </div>
  </form>
</body>
</html>