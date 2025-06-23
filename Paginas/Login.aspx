<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Asignacion2.Paginas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">Inicio de Seccion</asp:Label>
            <br />
            <asp:Label runat="server">Nombre De Usuario</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
            <br />
            <asp:Label runat="server">Ingresa La Clave</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtContra"></asp:TextBox>
            <br />
            <asp:Button Text="Ingresar" OnClick="btnIngresar_Click" ID="btnIngresar" runat="server"/>
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
