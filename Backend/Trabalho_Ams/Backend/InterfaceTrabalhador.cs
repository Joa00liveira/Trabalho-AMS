using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface InterfaceTrabalhador
    {
        public int AdicionarTrabalhador(Trabalhador trabalhador);
        public void RemoverTrabalhador(Trabalhador trabalhador);
        public bool TrabalhadorExiste(Trabalhador trabalhador);
        public void ListarTrabalhadores();

    }
}
