using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface InterfaceCliente
    {
        public int AdicionarCliente(int utilizadorid,DateTime DataAdesao,int contacto,string nome, DateTime Datanascimento);
        public int EliminarCliente(int utilizadorid);
        public int EfetuarPedido(string tiposervico,string detalhes, string emailtrabalhador, DateTime dataServico );

    }
}
