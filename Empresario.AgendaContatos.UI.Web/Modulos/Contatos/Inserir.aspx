<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutPadrao.master" AutoEventWireup="true" CodeFile="Inserir.aspx.cs" Inherits="Modulos_Contatos_Inserir" MaintainScrollPositionOnPostback="true"%>

<%@MasterType VirtualPath="~/LayoutPadrao.master" %>

<%@ Register src="../../Controles/webContato.ascx" tagname="webContato" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:webContato ID="webContato1" runat="server" />
</asp:Content>

