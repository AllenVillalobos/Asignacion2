<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HojaClinica.aspx.cs" Inherits="Asignacion2.Paginas.HojaClinica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">Usuario Conectado</asp:Label>
            <asp:TextBox ReadOnly="true" ID="txtUsuarios" runat="server"></asp:TextBox>
            <asp:Label runat="server">Fecha de Atencion:</asp:Label>
            <asp:TextBox ReadOnly="true" ID="txtFecha" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label>Identificador de Mascotas</asp:Label>
            <asp:TextBox runat="server" ID="txtIDMascota"></asp:TextBox>
            <asp:Button Text="Agregar" runat="server" ID="bntAgregar" />
            <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click"/>
            <br />
            <br />
            <asp:Label>Nombre de la Mascota</asp:Label>
            <asp:TextBox ID="txtNombreMas" runat="server"></asp:TextBox>
            <asp:Label>Peso Mascota</asp:Label>
            <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
            <asp:Label>Sexo</asp:Label>
            <asp:TextBox ID="txtSexo" runat="server" ReadOnly="true"></asp:TextBox>
            <asp:Label>Fecha de Nacimineto</asp:Label>
            <asp:TextBox ID="txtFechaNacimiento" runat="server" ReadOnly="true"></asp:TextBox>
            <br />
            <asp:Label>Alergias</asp:Label>
            <br />
            <asp:TextBox TextMode="MultiLine" Rows="3" Columns="90" runat="server" ID="txtAlergias"></asp:TextBox>
            <asp:Button Text="Actualizar Datos" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click"/>
        </div>
        <div>
            <asp:Label>Sintomas:</asp:Label>
            <br />
            <asp:TextBox TextMode="MultiLine" Rows="5" Columns="100" runat="server" ID="txtSintomas"></asp:TextBox>
            <br />
            <asp:Label>Diagnostico:</asp:Label>
            <br />
            <asp:TextBox TextMode="MultiLine" Rows="5" Columns="100" runat="server" ID="TextBox1"></asp:TextBox>
            <br />
            <asp:Label>Tratamiento:</asp:Label>
            <br />
            <asp:TextBox TextMode="MultiLine" Rows="5" Columns="100" runat="server" ID="TextBox2"></asp:TextBox>
            <br />
            <asp:Button runat="server" Text="Limpiar Campos" ID="btnLimpiar" />
            <asp:Button runat="server" Text="GuardarHoja" ID="btnGuardarHoja" />
        </div>
        <div>
            <asp:Label>Adicionado Por</asp:Label>
            <asp:TextBox ReadOnly="true" ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:Label>Fecha de Adicion</asp:Label>
            <asp:TextBox ReadOnly="true" ID="txtFechaAdicion" runat="server"></asp:TextBox>

            <asp:Label>Modificado Por</asp:Label>
            <asp:TextBox ReadOnly="true" ID="txtModificadoPor" runat="server"></asp:TextBox>
            <asp:Label>Fecha de Modificacion</asp:Label>
            <asp:TextBox ReadOnly="true" ID="txtFechaModificacion" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
