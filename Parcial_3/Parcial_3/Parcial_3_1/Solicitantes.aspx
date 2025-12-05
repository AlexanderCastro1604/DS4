<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solicitantes.aspx.cs" Inherits="Parcial_3_1.Solicitantes" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de Solicitantes</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Registro de Solicitantes</h2>

        Cédula:
        <asp:TextBox ID="txtCedula" runat="server" /><br /><br />

        Nombre:
        <asp:TextBox ID="txtNombre" runat="server" /><br /><br />

        Apellido:
        <asp:TextBox ID="txtApellido" runat="server" /><br /><br />

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar"
                    OnClick="btnGuardar_Click" /><br /><br />

        <asp:Label ID="lblMensaje" runat="server" ForeColor="Green" />
    </form>
</body>
</html>
