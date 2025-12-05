<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio201.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de Multiplicar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial; margin:20px;">
            <h2>Tabla de multiplicar (1 a 25)</h2>

            Número: <asp:TextBox runat="server" ID="txtNumero"></asp:TextBox>
            <asp:Button runat="server" ID="btnGenerar" Text="Generar" OnClick="btnGenerar_Click" />
            
            <br /><br />
            <asp:Literal runat="server" ID="litTabla"></asp:Literal>
        </div>
    </form>
</body>
</html>
