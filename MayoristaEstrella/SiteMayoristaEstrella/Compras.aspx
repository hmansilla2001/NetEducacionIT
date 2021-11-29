<%@ Page Title="Compras" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="SiteMayoristaEstrella.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Mis Compras</h1>
    <div>
        <asp:Label Text="Valor de la variable" ID="lblContador" runat="server"/>
    </div>

    <div>
        <asp:Button Text="PostBack" ID="btnPostback" OnClick="btnPostback_Click" runat="server"/>
    </div>

    <div>
        <asp:Label ID="lblMensaje" runat="server"/>
    </div>
</asp:Content>
