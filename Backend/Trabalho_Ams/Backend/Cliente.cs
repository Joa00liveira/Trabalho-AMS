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
        private Trabalhadores trabalhadores;


        public Cliente(int id, string nome, int idade, string password)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.password = password;
            this.pedidosDeServico = new List<Servico>();
            this.trabalhadores = new Trabalhadores();
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


        public void FazerPedidoServico(string tipoServico, string detalhesServico, Trabalhador trabalhador, DateTime dataServico)
        {
            // Verifica se a descrição do serviço não contém palavras-chave específicas
            if (!DescricaoContemPalavrasChave(detalhesServico))
            {
                Console.WriteLine("A descrição do serviço precisa conter informações relevantes. Melhore a descrição.");
                return;
            }
            // Verifica se o tipo de serviço NÃO existe
            if (ExisteTipoServico(tipoServico))
            {
                Console.WriteLine("Este tipo de serviço não está disponível. Escolha outro tipo de serviço.");
                return;
            }
            // Verifica se o trabalhador existe na lista de trabalhadores disponíveis
            if (trabalhadores.TrabalhadorExiste(trabalhador))
            {
                Console.WriteLine("O trabalhador especificado não está disponível. Escolha outro trabalhador.");
                return;
            }

            // Verifica se a especialização do trabalhador é compatível com o tipo de serviço
            if (!trabalhador.Especializacao.Equals(tipoServico, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("O trabalhador não possui a especialização necessária para este tipo de serviço. Escolha outro trabalhador.");
                return;
            }
            // Verifica se a data do serviço é maior que a data atual
            if (dataServico <= DateTime.Now)
            {
                Console.WriteLine("A data do serviço deve ser posterior à data atual. Escolha uma data válida.");
                return;
            }
            pedidosDeServico.Add(new Servico(tipoServico, detalhesServico,  dataServico));

        }

    }
}
