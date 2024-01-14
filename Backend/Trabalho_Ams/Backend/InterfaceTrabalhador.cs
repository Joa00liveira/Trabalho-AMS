using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface InterfaceTrabalhador
    {
        public void AdicionarTrabalhador(Trabalhador trabalhador);
        public void RemoverTrabalhador(Trabalhador trabalhador);
        public bool TrabalhadorExiste(Trabalhador trabalhador);
        public IEnumerable<Trabalhador> ListarTrabalhadores();
        public int PublicarServico(string tiposervico, string descServico, int preco, string precoNegociavel);


    }
}
