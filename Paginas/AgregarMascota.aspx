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
        <asp:ScriptManager runat="server" ID="ScriptManager1" />
        <div class="clinica-container">
            <div class="gradient-card">
                <asp:Label runat="server">Usuario Conectado</asp:Label><br />
                <asp:TextBox ReadOnly="true" ID="txtUsuarios" runat="server"
                    CssClass="form-control" /><br />
                <br />
                <h2 class="page-title">Agregar Mascota</h2>

                <label for="txtPropietarioID">Dueño</label>
                <asp:TextBox ID="txtPropietarioIdentificacion" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Button Text="Buscar Propietario" runat="server" OnClick="btnBuscarPropietario_Click" ID="btnBuscarPropietario" />
                <asp:Button Text="Agregar Propietario" runat="server" OnClick="btnAgregarPropietario_Click" ID="btnAgregarPropietario" />
                <label for="txtPropietarioNombre">Primer Nombre</label>
                <asp:TextBox ID="txtPropietarioNombre" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                <label for="txtApellido1">Primer Apellido</label>
                <asp:TextBox ID="txtApellido1" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                <label for="txtApellido2">Segundo Apellido</label>
                <asp:TextBox ID="txtApellido2" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                <br />
                <label for="txtApellido2">Correo Electronico</label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                <label for="txtCelular">Telefono Celular</label>
                <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Button Text="Actulizar Datos" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" />

                <label for="txtNombreMascota">Nombre Mascota</label>
                <asp:TextBox ID="txtNombreMascota" runat="server"
                    CssClass="form-control"
                    Placeholder="Nombre de la mascota" />

                <label for="txtNombreMascota">Fecha de Nacimiento</label>
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>
                        <asp:Calendar runat="server" ID="cldFechaNacimiento"></asp:Calendar>
                    </ContentTemplate>
                </asp:UpdatePanel>

                <label for="txtPesoMascota">Peso (kg)</label>
                <asp:TextBox ID="txtPesoMascota" runat="server"
                    CssClass="form-control"
                    Placeholder="Peso de la mascota" />

                <label for="txtPesoMascota">Sexo</label>
                <asp:DropDownList runat="server" ID="ddlSexo">
                </asp:DropDownList>

                <label for="txtAlergiasMascota">Alergias</label>
                <asp:TextBox ID="txtAlergiasMascota" runat="server"
                    CssClass="form-control"
                    TextMode="MultiLine" Rows="3"
                    Placeholder="Alergias conocidas" />

                <asp:Button ID="btnGuardarMascota" runat="server"
                    Text="Guardar Mascota"
                    CssClass="btn-primary"
                    OnClick="btnGuardarMascota_Click" />
                <asp:Button ID="btnLimpiar" runat="server"
                    Text="Limpiar"
                    CssClass="btn-primary"
                    OnClick="btnLimpiar_Click" />

                <asp:Label ID="lblMensajeMascota" runat="server"
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
