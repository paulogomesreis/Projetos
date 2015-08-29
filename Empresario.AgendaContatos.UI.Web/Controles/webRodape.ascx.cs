using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_webRodape : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Assim que o controle subir para a memória mandamos exibir a data corrente (DO WINDOWS)
        //DateTime -> Pegue a data e hora
        //Now ->Corrente, do próprio Windows
        //ToLongDateString -> A máscara de exibição de data (extenso)
        lblData.Text = DateTime.Now.ToLongDateString();
    }
}