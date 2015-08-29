using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modulos_Contatos_Alterar : System.Web.UI.Page
{
    //sempre que trabalharmos com querystring, 
    //enmvio de informações de uma pagian a outra
    //sempre validar os parametros de entrada
    //pode ser que o usuario tente burlar pra estourar um erro
    private void ValidarParametrosEntrada()
    {
        //resgatamos o parametro de entrada ID
        var codigo = Request["ID"];

        //Verficamos se o ID foi realmente enviado
        //matamos tres verificaçoes em uma
        // verificamos se foi enviado o ID
        //verificamos se foi enviado em branco
        //verificamos se foi enviado com espaços em branco
        if (String.IsNullOrWhiteSpace(codigo))
            Response.Redirect("Listar.aspx");
        //Validamos se o ID é realmente um numero
        //todos os tipos de dados tem o comando TryParse
        //ele verifica se um deteminado texto pode ser convertido para o tipo de dado informado
        //converteu = true e popula a variavel numeo com o informação de codigo
        //nao converteu = false
        Int32 numero;
        if(!Int32.TryParse(codigo, out numero))
            Response.Redirect("Listar.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Master.setarTitulo = "Alteração de contatos";

        ValidarParametrosEntrada();

    }
}