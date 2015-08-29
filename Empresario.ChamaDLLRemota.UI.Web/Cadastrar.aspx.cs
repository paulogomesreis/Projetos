using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//importamos uma namespace gerada dentro do proxy
using ProxyCliente;

public partial class Cadastrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //desativamos a validacao com jquery para validarmos com javascript
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }
    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        //pensando nos usuarios hacers que vao tentar desabilitar o javascript para simular erros, uma boa pratica é 
        //revalidar os campos no c#
        
        // se o usuario chegou aqui com algum campo obrigatorio em branco, utilizar a propriedade isvalid
        // se chegou com tudo preenchido = true
        //caso contrario = false
        if (!Page.IsValid)
        {
            if (txtTelefone.Text == string.Empty)
                Response.Write("Preencha o Nome <br/>");
            if (txtEndereco.Text == string.Empty)
                Response.Write("Preencha o Endereço <br/>");
            if (txtEmail.Text == string.Empty)
                Response.Write("Preencha o E-Mail <br/>");
            if (txtTelefone.Text == string.Empty)
                Response.Write("Preencha o Telefone <br/>");

            return;
        }

        //craiamos uma variavel apontando para o servico remoto
        var servico = new ContatoClient();

        //criamos uma variavel apontando para a tabela de clientes
        var novoCliente = new TB_CLIENTE();
        //fizemos o mapeamento(DataBind mapper)
        novoCliente.NM_CLIENTE = txtNome.Text;
        novoCliente.DS_ENDERECO = txtEndereco.Text;
        novoCliente.NR_TELEFONE = txtTelefone.Text;
        novoCliente.DS_EMAIL = txtEmail.Text;

        //enviamos os registros para a dll remota
        servico.Cadastrar(novoCliente);

        

    }
}