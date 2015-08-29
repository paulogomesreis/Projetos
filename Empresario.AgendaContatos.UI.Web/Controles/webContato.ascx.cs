using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Empresario.AgendaContatos.Business;
using Empresario.AgendaContatos.Model;

public partial class Controles_webContato : System.Web.UI.UserControl
{

    private readonly EstadoCivilBUS _negocioCivil = new EstadoCivilBUS();
    private readonly ContatoBUS _negocioContato = new ContatoBUS();

    //Linguagem UBIQUA
    //nao podemos declarar nomes de vaiaveis, metodos e propriedades com textos, nomes de palavras tecnicas ou reservadas
    //ex: CarregarGrid, CarregarDropDown...
    private void CarregarEstadoCivil()
    {
        //primeiro listamos a lista de estado civis com todos os estados civis 
        //que vieram no metodo listar
        ddlEstadoCivil.DataSource = _negocioCivil.Listar();
        //estas duas trabalahm em conjunto
        //DataTextField coluna ou texto que será exibido ao usuario
        //DataValueField coluna ou propriedade que armazenaremos a chave (fica oculta)
        ddlEstadoCivil.DataTextField = "Descricao";
        ddlEstadoCivil.DataValueField = "Codigo";

        //exiba os dados
        ddlEstadoCivil.DataBind();        
    }

    private void EditarContato()
    {
        // criamos um camando para colocar o contatno no modo de edição
        //vamos buscar o dados da tabela pelo ID
        //capturamos o codigo do contato que será editado
        var codigo = Convert.ToInt32(Request["ID"]);
        //buscamos as informações através do código
        var contato = _negocioContato.PesquisarPorCodigo(codigo);

        //pegamos os dados que vieram da tabela e 
        //jogamos o registro no modo de edição
        txtNome.Text = contato.Nome;
        txtEndereco.Text = contato.Endereco;
        txtEmail.Text = contato.Email;
        txtTelefone.Text = contato.Telefone;
        txtDataNascimento.Text = contato.DataNascimento.ToShortDateString();

        if (contato.Sexo.Codigo == 1)
            rdbFeminino.Checked = true;
        else
            rdbMasculino.Checked = true;

        ddlEstadoCivil.SelectedValue = contato.EstadoCivil.Codigo.ToString();

    }

    //criamos um comando para exibição de mensagens
    private void ExibirMensagem(String texto_)
    {
        //executamos comandos que rodam na maquina cliente
        //a partir do servidor, a partir do visual C#
        //mandamos 4 parametros
        //typeof(Page) -> vamos registrar esse comando em uma página(pagina corrente)
        //Mensagem -> é um alias para os comandos JAVASCRIPT
        //os comandos em si
        //true -> é para nao precisar abrir e fechar a tag SCRIPT
        Page.ClientScript.RegisterClientScriptBlock(typeof(Page),"MENSAGEM", "alert('" + texto_ + "');window.location='Listar.aspx';",true);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Quando a tela for para a memória, mandamos desativar as validações com JQUERY
        //Voltamos a validar com javascript puro
        //é uma novidade do ASP.NET 4.5
        //Page.UnobtrusiveValidationMode.None;
        //Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        //isPostBack serve para saber se a pagina esta sendo recarregada
        //true recarregada
        //false carregada
        //sempre passa no load prara depois passar no click do botão
        if (!Page.IsPostBack)
        {
            CarregarEstadoCivil();

            //esse controle é usado em duas paginas, inserir e editar então temos que separar as particulariedades de cada pagina
            if (Request.Path.EndsWith("Alterar.aspx"))
                EditarContato();
        }
        
    }
    
    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        //Limpámos a tela de uma forma genérica, não importa quantos controles tenham
        //sempre limparemos TODOS
        //Percorreremos o controle a controle que esta dentro do ASCX (WEB USER CONTROL)
        foreach (var controlePagina in Controls)
        {
            //IS serve para verificar o TIPO (CLASSE)
            //AS serve para converter para o TIPO do controle
            if (controlePagina is TextBox)
                (controlePagina as TextBox).Text = string.Empty;
            else if (controlePagina is RadioButton)
                (controlePagina as RadioButton).Checked = false;
            else if (controlePagina is DropDownList)
                (controlePagina as DropDownList).SelectedIndex = 0;
        }
        //Jogamos o cursor para o primeiro campo da tela
        txtNome.Focus();
    }
    
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        //independente da pagina aberta temos que pegar os dados da tela 
        // e jogar dentro do modelo
        var contato = new ContatoMOD();

        contato.Nome = txtNome.Text.Trim();
        contato.Endereco = txtEndereco.Text.Trim();
        contato.Email = txtEmail.Text.Trim();
        contato.Telefone = txtTelefone.Text.Trim();
        contato.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
        contato.EstadoCivil.Codigo = Convert.ToInt32(ddlEstadoCivil.SelectedValue);

        contato.Sexo.Codigo = (rdbFeminino.Checked ? 1 : 2);
        //operador ternario (IIF). é o if com apenas uma condição
        //isto é o mesmo que 
        //if (rdbFeminino.Checked)
        //    novoContato.Sexo.Codigo = 1;
        //else
        //    novoContato.Sexo.Codigo = 2;
        //segundo operador ternario semelhante ao isnull
        //var teste = novoContato ?? "oi";

        //começamos as prticulariedades por página
        if (Request.Path.EndsWith("Inserir.aspx"))
        {
            _negocioContato.Inserir(contato);
            ExibirMensagem("Cadastrado com sucesso!");
        }
        else
        {
            //para edição temos que passar o id do contato
            contato.Codigo = Convert.ToInt32(Request["ID"]);
            _negocioContato.Atualizar(contato);
            ExibirMensagem("Atualizazdo com sucesso!");
        }
    }
}