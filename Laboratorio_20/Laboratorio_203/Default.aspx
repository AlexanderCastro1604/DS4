<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio203.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Productos - CRUD</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:600px; margin:auto; font-family:Arial;">

            <h2>Gestión de Productos (LAPTOPS)</h2>

            <hr />

            <!-- BUSCAR -->
            <label>Buscar por ID:</label>
            <asp:TextBox ID="txtBuscarID" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>

            <hr />

            <!-- CAMPOS -->
            <label>ID:</label>
            <asp:TextBox ID="txtID" runat="server" Enabled="false"></asp:TextBox><br /><br />

            <label>Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />

            <label>Precio:</label>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox><br /><br />

            <label>Stock:</label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox><br /><br />

            <hr />

            <!-- BOTONES -->
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"/>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Enabled="false"/>
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" Enabled="false"/>
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Enabled="false"/>

        </div>
    </form>
</body>
</html>
