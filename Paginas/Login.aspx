<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Asignacion2.Paginas.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Inicio de Sesión</title>

  <!-- Enlace al archivo de estilos principal -->
  <link rel="stylesheet" href="~/Estilos/main.css" />
</head>
<body>
  <form id="form1" runat="server">
    <div class="login-container">

      <!-- Título del formulario de inicio de sesión -->
      <asp:Label runat="server" CssClass="login-title">
        Inicio de Sección
      </asp:Label>
      <br />

      <!-- Etiqueta para el campo de nombre de usuario -->
      <asp:Label runat="server" AssociatedControlID="txtNombre" CssClass="login-label">
        Nombre De Usuario
      </asp:Label>
      <br />

      <!-- Campo para ingresar el nombre de usuario -->
      <asp:TextBox 
        runat="server" 
        ID="txtNombre" 
        CssClass="form-control" 
        Placeholder="Usuario" />
      <br />

      <!-- Etiqueta para el campo de contraseña -->
      <asp:Label runat="server" AssociatedControlID="txtContra" CssClass="login-label">
        Ingresa La Clave
      </asp:Label>
      <br />

      <!-- Campo para ingresar la contraseña (oculta con asteriscos) -->
      <asp:TextBox 
        runat="server" 
        ID="txtContra" 
        CssClass="form-control" 
        TextMode="Password"
        Placeholder="••••••••" />
      <br />

      <!-- Botón para enviar los datos e intentar iniciar sesión -->
      <asp:Button 
        runat="server" 
        ID="btnIngresar" 
        Text="Ingresar" 
        CssClass="btn-primary"
        OnClick="btnIngresar_Click" />
      <br />

      <!-- Etiqueta para mostrar mensajes de error o información -->
      <asp:Label 
        ID="lblMensaje" 
        runat="server" 
        CssClass="error-msg" />
    </div>
  </form>
</body>
</html>
