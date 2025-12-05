<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="Parcial_3_1.Solicitudes" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de Solicitudes</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Registro de Solicitudes de Pasaporte</h2>

        ID Solicitante:
        <asp:TextBox ID="txtIdSolicitante" runat="server" /><br /><br />

        Observaciones:
        <asp:TextBox ID="txtObservaciones" runat="server" /><br /><br />

        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Solicitud"
                    OnClick="btnRegistrar_Click" /><br /><br />

        <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue" />
    </form>
</body>
</html>
