<%@ Control Language="C#" AutoEventWireup="true" CodeFile="webContato.ascx.cs" Inherits="Controles_webContato" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style7 {
        width: 270px;
    }
    .auto-style8 {        height: 61px;
    }
    .auto-style9 {
        height: 23px;
    }
    .auto-style10 {
        width: 270px;
        height: 23px;
    }
    .auto-style11 {
        height: 26px;
    }
    .auto-style12 {
        width: 270px;
        height: 26px;
    }
    .auto-style13 {
        width: 156px;
    }
    .auto-style14 {
        width: 156px;
        height: 26px;
    }
    .auto-style15 {
        width: 156px;
        height: 23px;
    }
</style>
<script>
    function ValidaSexo(sender, e) {
        //Capturamos os radioButtons da tela 
        //JavaScript Moderno disponivel desde o IE8
        //Trocar todos os getElementById por querySelector
        var feminino = document.querySelector("#rdbFeminino");
        var masculino = document.querySelector("#rdbMasculino");

        //Verificamos se algum dos dois radiosbuttons foi checado
        //Fizemos um if com ou (or)
        //se um estiver marcado ele retorna TRUE
        //se os 2 estiverem desmarcados ele retorna FALSE
        e.IsValid = feminino.checked || masculino.checked;
    }
</script>
<table class="auto-style1">
    <tr>
        <td class="auto-style8" colspan="3">
            <asp:ValidationSummary ID="vsmErros" runat="server" Font-Bold="True" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" />
        </td>
    </tr>
    <tr>
        <td class="auto-style13">
            <asp:Label ID="lblNome" runat="server" AssociatedControlID="txtNome" Text="Nome"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:TextBox ID="txtNome" runat="server" AccessKey="M" ToolTip="Aperte ALT+M" Width="290px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Informe o Nome" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"><img src="../../imagens/1361758351_exclamation.png" /></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style14">
            <asp:Label ID="lblEndereco" runat="server" AssociatedControlID="txtEndereco" Text="Endereço"></asp:Label>
        </td>
        <td class="auto-style12">
            <asp:TextBox ID="txtEndereco" runat="server" AccessKey="L" ToolTip="Aperte ALT+L" Width="284px"></asp:TextBox>
        </td>
        <td class="auto-style11">
            <asp:RequiredFieldValidator ID="rfvEndereco" runat="server" ControlToValidate="txtEndereco" ErrorMessage="Informe o Endereço" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"><img src="../../imagens/1361758351_exclamation.png" /></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style14">
            <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="E-Mail"></asp:Label>
        </td>
        <td class="auto-style12">
            <asp:TextBox ID="txtEmail" runat="server" Width="286px"></asp:TextBox>
        </td>
        <td class="auto-style11">
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Informe o E-Mail" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"><img src="../../imagens/1361758351_exclamation.png" /></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-Mail Inválido" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"><img src="../../imagens/1361758351_exclamation.png" /></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">
            <asp:Label ID="lblTelefone" runat="server" AssociatedControlID="txtTelefone" Text="Telefone"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvTelefone" runat="server" ControlToValidate="txtTelefone" ErrorMessage="Informe o Telefone" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"><img src="../../imagens/1361758351_exclamation.png" /></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style15"></td>
        <td class="auto-style10"></td>
        <td class="auto-style9"></td>
    </tr>
    <tr>
        <td class="auto-style13">
            <asp:Label ID="lblDataNascimento" runat="server" AssociatedControlID="txtDataNascimento" Text="Data de Nascimento"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvDataNascimento" runat="server" ControlToValidate="txtDataNascimento" ErrorMessage="Informe a Data de Nascimento" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"><img src="../../imagens/1361758351_exclamation.png" /></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">
            <asp:Label ID="lblSexo" runat="server" AssociatedControlID="rdbFeminino" Text="Sexo"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:RadioButton ID="rdbFeminino" runat="server" GroupName="Sexo" Text="Feminino" ClientIDMode="Static" />
&nbsp;<asp:RadioButton ID="rdbMasculino" runat="server" GroupName="Sexo" Text="Masculino" ClientIDMode="Static" />
        </td>
        <td>
            <asp:CustomValidator ID="ctvSexo" runat="server" ErrorMessage="Informe o Sexo" Font-Bold="True" ForeColor="Red" ClientValidationFunction="ValidaSexo"><img src="../../imagens/1361758351_exclamation.png" /></asp:CustomValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">
            <asp:Label ID="lblEstadoCivil" runat="server" AssociatedControlID="ddlEstadoCivil" Text="Estado Civil"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:DropDownList ID="ddlEstadoCivil" runat="server" Height="22px" Width="166px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:CompareValidator ID="cpvEstadoCivil" runat="server" ControlToValidate="ddlEstadoCivil" ErrorMessage="Informe o Estado Civil" Font-Bold="True" ForeColor="Red" Operator="NotEqual" SetFocusOnError="True" ValueToCompare="Selecione..."><img src="../../imagens/1361758351_exclamation.png" /></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style7">
            <asp:Button ID="btnLimpar" runat="server" OnClick="btnLimpar_Click" Text="Limpar" CausesValidation="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>

