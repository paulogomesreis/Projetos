using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IContato" in both code and config file together.
//Foi esse atributo quem falou que a nossa DLL vai ser acessada remotamente pelo protocolo http
[ServiceContract]
public interface IContato
{
    //para que as operacoes sejam visiveis a todos pelo protocolo http, deve-se colocar o atributo OperationContract. Semelhante ao atributo public
    //criamos um metodo para adicionar contatos na tabela
    // ninguem mais acessa diretamente banco ou tabela
    // todo acesso é feito através de um serviço, dll remota ou classe remota
    [OperationContract]    
    String Cadastrar(TB_CLIENTE cliente_);

    //craimos um metodo para retornar todos os registros da tabela
    [OperationContract]
    List<TB_CLIENTE> Listar();


}
