using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LayoutPadrao : System.Web.UI.MasterPage
{
    //Criamos uma propriedade pública
    //de qualquer lugar do projeto
    //set se chama ACESSOR, estamos disponibilizando
    //essa propriedade para GRAVAÇÃO
    public String setarTitulo
    {
        //FindControl busca um controle pelo nome e o as Label é para fazer a conversão (UNBOXING) para o controle Label
        set
        {
            var label = webTitulo1.FindControl("lblTitulo") as Label;

            //Setamos o texto enviado pela a página FILHA
            label.Text = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
