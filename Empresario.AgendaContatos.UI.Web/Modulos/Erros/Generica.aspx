<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutPadrao.master" AutoEventWireup="true" CodeFile="Generica.aspx.cs" Inherits="Modulos_Erros_Generica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Ops! Acho que o Dimas fez XAMBERS!!!"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblErro" runat="server" Text="Erro:"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblIp" runat="server" Text="IP:"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuário"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <input id="Button1" type="button" value="Voltar" onclick="window.history.go(-1);"/></td>
    </tr>
</table>
</asp:Content>

