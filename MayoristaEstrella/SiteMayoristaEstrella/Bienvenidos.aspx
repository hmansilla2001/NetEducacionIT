<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenidos.aspx.cs" Inherits="SiteMayoristaEstrella.Bienvenidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="myhead" runat="server">
    <title>Bienvenidos!!</title>
</head>
<body style="background-color:Green">
    <form id="form1" runat="server">
        <div>
           <h1>Bienvenidos al curso de .Net</h1>
           <h2>Iniciando en el mundo Web!</h2>

            <asp:Label Text="Nombre: " runat="server" ForeColor="#CC0000" />
            <asp:TextBox ID="txtNombre" runat="server"  ForeColor="#CC0000" />
            <asp:Button Text="Dar Bienvenida"  ID="btnBienvenida"  OnClick="btnBienvenida_Click"  runat="server" />

            <div>
                <asp:Label Text="" ID="lblMensaje" runat="server" />
            </div>

            <div>

                <asp:CheckBox ID="chkRock" Text="Rock" runat="server" />
                <asp:CheckBox ID="chkPop" Text="Pop" runat="server" />
                <br />
                <asp:RadioButton ID="radioCasado" Text="Casado" runat="server" />
                <asp:RadioButton ID="radioSoltero" Text="Soltero" runat="server" />
                <br />  
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
               <br />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </div>


        </div>
    </form>
</body>
</html>
