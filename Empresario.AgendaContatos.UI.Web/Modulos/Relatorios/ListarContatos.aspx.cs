using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Importamos uma namespace para podermos visualizar todas as classes de manipulacao de relatorio
using Microsoft.Reporting.WebForms;
using Empresario.AgendaContatos.Business;
using Empresario.AgendaContatos.Model;

public partial class Modulos_Relatorios_ListarContatos : System.Web.UI.Page
{
    private readonly ContatoBUS _negocio = new ContatoBUS();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            // Assim que a pagina for para a memoria temos que pegar as inf do business
            //e jogar Para o report viewer
            //dsREGISTROS é o nome do dataset que foi configurado no relatório
            var dados = new ReportDataSource("dsREGISTROS", _negocio.Listar());

            //depois de configurar os dados na memoria
            //repassamos para o repotviewer
            rpvContatos.LocalReport.DataSources.Add(dados);
            rpvContatos.LocalReport.Refresh(); 
        }
    }
}