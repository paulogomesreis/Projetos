using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modulos_Erros_Erro404 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //pegamos o nome da pagina que o usuario
        //tentou acessar o não existe
        lblPagina.Text += Request["AspxErrorPath"];

        //Pegamos o ip da maquina do usuário
        lblIp.Text += Request.UserHostAddress;

        //pegamos o nome do usuário que está logado na aplicação
        lblUsuario.Text += User.Identity.Name;
    }
}