using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Empresario.SisCliente.Model;
using Empresario.sisCliente.Business;

namespace Empresario.SisCliente.UI.Web.Modulos.Clientes
{
    public partial class Inserir : System.Web.UI.Page
    {

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClienteMOD modelo = new ClienteMOD();
            ClienteBus negocio = new ClienteBus(modelo);


            modelo.Nome = txtNome.Text.Trim();
            modelo.Endereco = txtEndereco.Text.Trim();
            modelo.Telefone = txtTelefone.Text.Trim();
            modelo.Email = txtEmail.Text.Trim();

            try
            {
                negocio.ValidarDados();
                negocio.CadastrarCliente();
            }
            catch (Exception erroNegocio)
            {
                //boas praticas como enviar um alerta em uma pagina asp.net RegisterStartupScript carrega a pagina antes do script javascript RegisterBlockScript
                ClientScript.RegisterStartupScript(Page.GetType(), "MENSAGENS", "alert('" + erroNegocio.Message + "');", true);
            }
           
        }
    }
}