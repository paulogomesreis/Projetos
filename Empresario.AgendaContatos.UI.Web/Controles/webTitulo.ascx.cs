using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_webTitulo : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void imbFechar_Click(object sender, ImageClickEventArgs e)
    {
        //Redirecionamos o usuário para a página PRINCIPAL
        Response.Redirect("~/Home.aspx");
    }
}