using System;

namespace Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar Clientes
            Clientes gerenciadorClientes = new Clientes();
            Cliente cliente1 = new Cliente(1, "John Doe", 30, "password123");
            Cliente cliente2 = new Cliente(2, "Jane Doe", 25, "password456");

            gerenciadorClientes.AdicionarCliente(cliente1);
            gerenciadorClientes.AdicionarCliente(cliente2);

            // Criar Serviços
            Servicos gerenciadorServicos = new Servicos();
            Servico servico1 = new Servico("Construção", "Detalhes serviço 1", DateTime.Now.AddDays(7), 1, 100, true);
            Servico servico2 = new Servico("Pintura", "Detalhes serviço 2", DateTime.Now.AddDays(14), 1, 150, false);

            gerenciadorServicos.AdicionarServico(servico1);
            gerenciadorServicos.AdicionarServico(servico2);

            // Criar Trabalhadores
            Trabalhadores gerenciadorTrabalhadores = new Trabalhadores();
            Trabalhador trabalhador1 = new Trabalhador(1, "Trabalhador 1", "trabalhador1@example.com", "Construção");
            Trabalhador trabalhador2 = new Trabalhador(2, "Trabalhador 2", "trabalhador2@example.com", "Pintura");

            gerenciadorTrabalhadores.AdicionarTrabalhador(trabalhador1);
            gerenciadorTrabalhadores.AdicionarTrabalhador(trabalhador2);

            // Exemplo de uso: Listar todos os clientes
            Console.WriteLine("Todos os Clientes:");
            var todosClientes = gerenciadorClientes.ObterTodosClientes();
            foreach (var cliente in todosClientes)
            {
                Console.WriteLine($"ID do Cliente: {cliente.Id}, Nome: {cliente.Nome}, Idade: {cliente.Idade}");
            }

            // Exemplo de uso: Listar todos os serviços
            Console.WriteLine("\nTodos os Serviços:");
            var todosServicos = gerenciadorServicos.ObterTodosServicos();
            foreach (var servico in todosServicos)
            {
                Console.WriteLine($" Tipo: {servico.TipoServico}, Detalhes: {servico.DetalhesServico}, Data: {servico.DataServico}");
            }

            // Exemplo de uso: Listar todos os trabalhadores
            Console.WriteLine("\nTodos os Trabalhadores:");
            gerenciadorTrabalhadores.ListarTrabalhadores();
        }
    }
}
