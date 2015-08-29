using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresario.SisCliente.DataAccess;
using Empresario.SisCliente.Model;

namespace Empresario.SisCliente.Repository
{
    public sealed class ClienteREP
    {
        public void Adicionar(ClienteMOD dadosTela_)
        {
            using (EMPRESARIOEntities conexao = new EMPRESARIOEntities())
            {
                TB_CLIENTE novoCliente = new TB_CLIENTE();
                novoCliente.NM_CLIENTE = dadosTela_.Nome;
                novoCliente.DS_ENDERECO = dadosTela_.Endereco;
                novoCliente.NR_TELEFONE = dadosTela_.Telefone;
                novoCliente.DS_EMAIL = dadosTela_.Email;

                conexao.TB_CLIENTE.Add(novoCliente);
                conexao.SaveChanges();
            }
        }
    }
}
