using System;
using System.Collections.Generic;

namespace Backend
{
    public class Servicos
    {
        private List<Servico> servicosLista;

        public Servicos()
        {
            servicosLista = new List<Servico>();
        }

        public void AdicionarServico(Servico servico)
        {
            servicosLista.Add(servico);
        }


        public bool RemoverServico(Servico servico)
        {


            if (servico != null)
            {
                servicosLista.Remove(servico);
                return true;
            }

            return false;
        }


        public List<Servico> ObterTodosServicos()
        {
            return new List<Servico>(servicosLista);
        }
    }
}
