using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend
{
    public class Trabalhadores : InterfaceTrabalhador
    {
        private List<Trabalhador> listaTrabalhadores;

        public Trabalhadores()
        {
            listaTrabalhadores = new List<Trabalhador>();
        }

        public int AdicionarTrabalhador(Trabalhador trabalhador)
        {
            foreach (string s in Servico.tiposDeServicoValidos)
            {
                if (trabalhador.Especializacao == s)
                {
                    listaTrabalhadores.Add(trabalhador);
                    return 0;
                }
            }
            return -1;
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

        public void ListarTrabalhadores()
        {
            foreach (Trabalhador t in listaTrabalhadores)
            {
                Console.WriteLine($"ID: {t.Id} Nome: {t.Nome} | Esp.: {t.Especializacao} Email: {t.Email}");
            }
        }
    }
}
