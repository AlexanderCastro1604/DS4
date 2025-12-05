<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio202.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz N x N</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial; margin:20px;">
            <h2>Matriz N x N (diagonal inversa = 1)</h2>

            N: <asp:TextBox runat="server" ID="txtN"></asp:TextBox>
            <asp:Button runat="server" ID="btnGenerar" Text="Generar" OnClick="btnGenerar_Click" />
            
            <br /><br />
            <asp:Literal runat="server" ID="litMatriz"></asp:Literal>
        </div>
    </form>
</body>
</html>
