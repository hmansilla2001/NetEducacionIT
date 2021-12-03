<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevaMedida.aspx.cs" Inherits="SiteMayoristaEstrella.NuevaMedida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div>
        <h1>Nueva Medida</h1>
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción:"></asp:Label>            <br />            <asp:TextBox ID="txtDescripcion" runat="server" Width="300px"></asp:TextBox>            <br />            <p />            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />

    </div>
</asp:Content>
