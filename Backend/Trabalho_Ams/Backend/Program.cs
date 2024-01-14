using System;

namespace Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar um Utilizador
            Utilizador u1 = new Utilizador(1, "NomeUtilizador", 25, "senha");

            // Adicionar alguns trabalhadores
            Trabalhadores trabalhadores = new Trabalhadores();
            Trabalhador trab1 = new Trabalhador(1,"Trab1", "trab1@example.com", "Construção");
            Trabalhador trab2 = new Trabalhador(2,"Trab2", "trab2@example.com", "Design de Interiores");
            Trabalhador trab3 = new Trabalhador(3,"Trab3", "trab3@example.com", "woows");

            trabalhadores.AdicionarTrabalhador(trab1);
            trabalhadores.AdicionarTrabalhador(trab2);

            // Solicitar um serviço
            DateTime dataServico = DateTime.Now.AddDays(7);  // Exemplo: serviço daqui a 7 dias
            u1.FazerPedidoServico("Construção", "orçamento", trab1, dataServico);

            // Listar trabalhadores
            Console.WriteLine("Trabalhadores disponíveis:");
            foreach (var trabalhador in trabalhadores.ListarTrabalhadores())
            {
                Console.WriteLine($"ID: {trabalhador.Id}, Nome: {trabalhador.Nome}, Email: {trabalhador.Email}, Especialização: {trabalhador.Especializacao}");
            }

        }
    }
}

