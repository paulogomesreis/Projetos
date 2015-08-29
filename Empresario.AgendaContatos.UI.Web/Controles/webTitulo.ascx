<%@ Control Language="C#" AutoEventWireup="true" CodeFile="webTitulo.ascx.cs" Inherits="Controles_webTitulo" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 541px;
    }
    .auto-style3 {
        width: 39px;
    }
    .auto-style4 {
        width: 179px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style3">
            <asp:Image ID="imgTitulo" runat="server" ImageUrl="~/Imagens/informacao.png" />
        </td>
        <td class="auto-style2">
            <asp:Label ID="lblTitulo" runat="server" Text="TÍTULO DA PÁGINA"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:ImageButton ID="imbFechar" runat="server" ImageUrl="~/Imagens/deletar.png" OnClick="imbFechar_Click" style="width: 16px" CausesValidation="False" />
        </td>
    </tr>
</table>

