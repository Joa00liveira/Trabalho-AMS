using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Projeto.Pages
{
    public class CriarPedidoModel : PageModel
    {
        public string Mensagem { get; set; }

        public void OnGet()
        {
            // Lógica para processar a solicitação GET, se necessário
        }

        public void OnPost()
        {
            // Acesso aos dados do formulário usando o objeto Request.Form
            var tipoServico = Request.Form["tipoServico"];
            var detalhes = Request.Form["detalhes"];
            var arquitetoDesigner = Request.Form["arquitetoDesigner"];
            var data = Request.Form["data"];

            // Verifica se os campos são nulos ou vazios
            if (string.IsNullOrWhiteSpace(tipoServico) ||
                string.IsNullOrWhiteSpace(detalhes) ||
                string.IsNullOrWhiteSpace(arquitetoDesigner) ||
                string.IsNullOrWhiteSpace(data))
            {
                Mensagem = "Por favor, preencha todos os campos do formulário.";
                return;
            }

            // Simulando o armazenamento em um banco de dados
            var pedidoService = new PedidoService();
            pedidoService.SalvarPedido(new Pedido
            {
                TipoServico = tipoServico,
                Detalhes = detalhes,
                Data = DateTime.Parse(data)
            });

            Mensagem = "Pedido criado com sucesso!";
        }

        // Simulação de uma classe de serviço que interage com um banco de dados
        public class PedidoService
        {
            private static readonly List<Pedido> _bancoDeDados = new List<Pedido>();

            public void SalvarPedido(Pedido pedido)
            {
                // Simula a adição do pedido ao banco de dados
                _bancoDeDados.Add(pedido);
            }
        }

        // Simulação da entidade Pedido
        public class Pedido
        {
            public string TipoServico { get; set; }
            public string Detalhes { get; set; }
            public string ArquitetoDesigner { get; set; }
            public DateTime Data { get; set; }
        }
    }
}



