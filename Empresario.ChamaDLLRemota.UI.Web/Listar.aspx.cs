using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//importamos a namespace do proxy, para podermos manipular as classes da DLL remota(serviço)
using ProxyCliente;

public partial class Listar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //assim que a pagina subir para a memoria conectmamos na dll remota e trazemos todos os registros da tabela, jogando no grid
        //a classe gerada pelo proxy segue essa nomenclatura NomedoServicoClient
        var servico = new ContatoClient();

        //descemos os dados da tabela pra dentro do grid, atraves do servico wcf
        GridView1.DataSource = servico.Listar();
        GridView1.DataBind();

    }
}