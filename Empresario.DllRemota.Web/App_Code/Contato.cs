using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Contato" in code, svc and config file together.
public class Contato : IContato
{

    public String Cadastrar(TB_CLIENTE cliente_)
    {
        //pegamos as informações que vieram via parametro de entrada e enviamos para a tabela. abrimos uma conexao com o ef
        using (var conexao = new EMPRESARIOEntities())
        {
            conexao.TB_CLIENTE.Add(cliente_);
            conexao.SaveChanges();
            return "Registro cadastrado com sucesso!";
        }
       
    }

    public List<TB_CLIENTE> Listar()
    {
        using(var conexao = new EMPRESARIOEntities())
        {
            return conexao.TB_CLIENTE.ToList();
        }
       
    }
}
