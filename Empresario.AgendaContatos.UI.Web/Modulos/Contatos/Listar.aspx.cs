using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Empresario.AgendaContatos.Model;
using Empresario.AgendaContatos.Business;

public partial class Modulos_Contatos_Listar : System.Web.UI.Page
{
    private readonly ContatoBUS _negocio = new ContatoBUS();
    private void CarregarContatos()
    {
        //mandamos carregar o grid
        grvContatos.DataSource = _negocio.Listar();
        grvContatos.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Assim que página subir para a memória mandamos setar o título
        //Para poder visualizar todos os membros público de uma página PAI, temos que
        //importar a direiva MasterType lá no ASPX lá em cima.
        Master.setarTitulo = "Lista de contatos";

        CarregarContatos();
    }

    protected void grvContatos_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Se entrou no RowDeleting o usuario clicou no deletar
        //temos que pegar o codigo que ele pediu para deletar
        //e exluir o registro
        //e->linha corrente
        //values paga informação da linha corrnte que ele pediu para excluir
        //
        var codigo = Convert.ToInt32(e.Values["Codigo"]);

        //depois de armaznar o codigo do contato
        //mandamos deletar o registro
        _negocio.Excluir(codigo);
        
        //mandamos recarrregar o grid
        CarregarContatos();

    }
}