using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresario.SisCliente.Model
{
    public sealed class ClienteMOD
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
    }
}
