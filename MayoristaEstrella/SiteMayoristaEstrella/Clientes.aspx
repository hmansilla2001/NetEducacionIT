<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="SiteMayoristaEstrella.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Clientes</h1>
    <asp:GridView ID="gridClientesDataList" runat="server" OnRowDataBound="gridClientesDataList_RowDataBound" CellPadding="4" ForeColor="#33333" GridLines="Both" AutoGenerateColumns="false">
        <AlternatingRowStyle BackColor = "White" ForeColor="#284775"/>
        <Columns>
            <asp:BoundField DataField="IdCliente" HeaderText="Codigo"/>
            <asp:BoundField DataField="NombreApellido" HeaderText="Nomber y Apellido"/>
            <asp:BoundField DataField="Domicilio" HeaderText="Domicilio"/>
            <asp:BoundField DataField="DNI" HeaderText="DNI"/>
            <asp:BoundField DataField="Telefono" HeaderText="Telefono"/>
            <asp:BoundField DataField="Celular" HeaderText="Celular"/>
            <asp:BoundField DataField="Mail" HeaderText="Mail"/>
        </Columns>
        <EditRowStyle BackColor="#999999"/>
        <FooterStyle BackColor="#5D789D" Font-Bold="true" ForeColor="White"/>
        <HeaderStyle BackColor="#5D789D" Font-Bold="true" ForeColor="White"/>
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center"/>
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333"/>
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="false" ForeColor="#33333"/>
        <SortedAscendingCellStyle BackColor="#E9E7E2"/>
        <SortedAscendingHeaderStyle BackColor="#506C8C"/>
        <SortedDescendingCellStyle BackColor="#FFFDF8"/>
        <SortedDescendingHeaderStyle BackColor="#6F8DAE"/>
    </asp:GridView>
    <br />
    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"  />
    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click"  />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"  />
</asp:Content>
