using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Assim que página subir para a memória mandamos setar o título
        //Para poder visualizar todos os membros público de uma página PAI, temos que
        //importar a direiva MasterType lá no ASPX lá em cima.
        Master.setarTitulo = "Bem vindo a página principal";
    }
}