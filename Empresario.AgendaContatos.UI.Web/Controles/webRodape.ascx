<%@ Control Language="C#" AutoEventWireup="true" CodeFile="webRodape.ascx.cs" Inherits="Controles_webRodape" %>
<style type="text/css">
    .auto-style11 {
        width: 100%;
    }
    .auto-style12 {
        width: 942px;
    }
    .auto-style14 {
        width: 39px;
    }
    .auto-style15 {
        width: 38px;
    }
</style>

<table class="auto-style11">
    <tr>
        <td class="auto-style14">
            <asp:Image ID="imgUsuario" runat="server" ImageUrl="~/Imagens/usuario.png" />
        </td>
        <td class="auto-style12">
            <asp:LoginName ID="lngUsuario" runat="server" />
        </td>
        <td class="auto-style15">
            <asp:Image ID="imgData" runat="server" ImageUrl="~/Imagens/calendario.png" />
        </td>
        <td>
            <asp:Label ID="lblData" runat="server" Text="16/07/2013"></asp:Label>
        </td>
    </tr>
</table>

