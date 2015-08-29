<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inserir.aspx.cs" Inherits="Empresario.SisCliente.UI.Web.Modulos.Clientes.Inserir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 161px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Nome do Cliente:</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" Width="408px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Endereço:</td>
                <td>
                    <asp:TextBox ID="txtEndereco" runat="server" Width="487px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Telefone:</td>
                <td>
                    <asp:TextBox ID="txtTelefone" runat="server" Width="198px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">E-mail:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="405px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
                </td>
            </tr>
        </table>
    </form>    
</body>
</html>
