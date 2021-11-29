<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploEventoLoad.aspx.cs" Inherits="SiteMayoristaEstrella.EjemploEventoLoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="" ID="lblBienvenida" runat="server" />
        </div>
         <div>
            <asp:TextBox runat="server" ID="txtNombre" />
         </div>
         <div>
            <asp:Button runat="server" ID="btnMostrarMensaje" OnClick="btnMostrarMensaje_Click" Text="Indique su nombre" />
         </div>
         <div>
            <asp:Label Text="" ID="lblBienvenida2" runat="server" />
         </div>

    </form>
</body>
</html>
