<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutPadrao.master" AutoEventWireup="true" CodeFile="Listar.aspx.cs" Inherits="Modulos_Contatos_Listar" %>

<%@MasterType VirtualPath="~/LayoutPadrao.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="grvContatos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="grvContatos_RowDeleting" EmptyDataText="Não há Contatos Cadastrados!">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField DeleteText="Deletar" ShowDeleteButton="True" />
            <asp:HyperLinkField Text="Editar" DataNavigateUrlFields="Codigo" DataNavigateUrlFormatString="Alterar.aspx?ID={0}" />
            <asp:BoundField HeaderText="Código" DataField="Codigo" />
            <asp:BoundField HeaderText="Nome" DataField="Nome" />
            <asp:BoundField HeaderText="E-Mail" DataField="Email" />
            <asp:BoundField HeaderText="Data de Nascimento" DataField="DataNascimento" DataFormatString="{0:dd/MM/yyyy}" />
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="btnNovo" runat="server" PostBackUrl="~/Modulos/Contatos/Inserir.aspx" Text="Novo Contato" />
</asp:Content>

