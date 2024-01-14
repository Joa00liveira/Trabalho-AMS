using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend
{
    public class Trabalhadores
    {
        private List<Trabalhador> listaTrabalhadores;

        public Trabalhadores()
        {
            listaTrabalhadores = new List<Trabalhador>();
        }

        public void AdicionarTrabalhador(Trabalhador trabalhador)
        {
            listaTrabalhadores.Add(trabalhador);
        }

        public void RemoverTrabalhador(Trabalhador trabalhador)
        {
            listaTrabalhadores.Remove(trabalhador);
        }

        public bool TrabalhadorExiste(Trabalhador trabalhador)
        {
            foreach (var t in listaTrabalhadores)
            {
                if (t.Id == trabalhador.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<Trabalhador> ListarTrabalhadores()
        {
            return listaTrabalhadores;
        }
    }
}
