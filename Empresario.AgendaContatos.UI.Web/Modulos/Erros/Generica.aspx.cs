using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modulos_Erros_Generica : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //pegamos o ultimo erro que aconteceu no servidor para o usuario corrente 
        //SE DEU ERRO EM QUALQUER PONTO LOCAL DO PROJETO QUE NÃO TENHA NADA A VER
        //COM O REPORT VIEWER, PEGAR O ERRO PELO INNEREXCEPTION
        //SE DEU ERRO NO REPORT VIEWER NÃO UTILIZAR INNEREXCEPTION
        if(Server.GetLastError().InnerException != null)
            lblErro.Text += Server.GetLastError().InnerException.Message;
        else
            lblErro.Text += Server.GetLastError().Message;

        //Pegamos o ip da maquina do usuário
        lblIp.Text += Request.UserHostAddress;

        //pegamos o nome do usuário que está logado na aplicação
        lblUsuario.Text += User.Identity.Name;
    }
}