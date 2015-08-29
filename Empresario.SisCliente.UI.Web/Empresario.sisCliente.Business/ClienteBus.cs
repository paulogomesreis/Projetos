using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresario.SisCliente.Model;
using Empresario.SisCliente.Repository;

namespace Empresario.sisCliente.Business
{
    public sealed class ClienteBus
    {
        private ClienteMOD _dadosTela;

        public ClienteBus(ClienteMOD dadosTela_)
        {
            _dadosTela = dadosTela_;

        }
        public void ValidarDados()
        {
            if (_dadosTela.Nome == String.Empty)
            {
                throw new ApplicationException("Preencha o nome");
            }
            if (_dadosTela.Endereco == string.Empty)
            {
                throw new ApplicationException("Preencha o endereço");
            }
            if (_dadosTela.Telefone == string.Empty)
            {
                throw new ApplicationException("Preencha o telefone");
            }
            if (_dadosTela.Email == string.Empty)
            {
                throw new ApplicationException("Preencha o e-mail");
            }

        }

        public void CadastrarCliente()
        {
            ClienteREP repositorio = new ClienteREP();
            repositorio.Adicionar(_dadosTela);
        }
    }
}

