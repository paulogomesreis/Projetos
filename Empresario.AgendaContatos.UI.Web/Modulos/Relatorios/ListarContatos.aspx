<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutPadrao.master" AutoEventWireup="true" CodeFile="ListarContatos.aspx.cs" Inherits="Modulos_Relatorios_ListarContatos" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <rsweb:ReportViewer ID="rpvContatos" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1099px">
        <LocalReport ReportPath="Modulos\Relatorios\ListarContatos.rdlc">
        </LocalReport>
    </rsweb:ReportViewer>
</asp:Content>

