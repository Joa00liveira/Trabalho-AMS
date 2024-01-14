using System;
using System.Collections.Generic;

namespace Backend
{
    public class Cliente
    {
        private int id;
        private string nome;
        private int idade;
        private string password;
        private List<Servico> pedidosDeServico;


        public Cliente(int id, string nome, int idade, string password)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.password = password;
            this.pedidosDeServico = new List<Servico>();
        }

        public int Id
        {
            get { return id; }
        }

        public string Nome
        {
            get { return nome; }
        }

        public int Idade
        {
            get { return idade; }
        }

        public string Password
        {
            get { return password; }
        }

        public bool ExisteTipoServico(string tipoServico)
        {
            // Verifica se existe pelo menos um pedido de serviço com o tipo específico
            foreach (var servico in pedidosDeServico)
            {
                if (servico.TipoServico.Equals(tipoServico, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public bool DescricaoContemPalavrasChave(string descricao)
        {
            string[] palavrasChaves = { "orçamento", "materiais" };
            foreach (var palavraChave in palavrasChaves)
            {
                if (descricao.Contains(palavraChave, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public void EfetuarPedido(string tiposervico, string detalhes, string emailtrabalhador, DateTime dataServico)
        {
            if (!Servico.tiposDeServicoValidos.Contains(tiposervico, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Tipo de serviço inválido.");
                return;
            }

            if (!DescricaoContemPalavrasChave(detalhes))
            {
                Console.WriteLine("Detalhes contêm palavras-chave que não estão.");
                return;
            }

            if (dataServico <= DateTime.Today)
            {
                Console.WriteLine("Data do serviço invalida");
                return;
            }

            Console.WriteLine("Pedido de serviço válido. Enviar para processamento...");

        }

    }
}
