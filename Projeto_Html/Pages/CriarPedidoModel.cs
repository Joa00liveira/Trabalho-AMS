using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

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

            // Verificar se o tipo de serviço está disponível
            if (!TipoServicoDisponivel(tipoServico))
            {
                Mensagem = "Tipo de serviço não encontrado.";
                return;
            }

            // Verificar palavras-chave na descrição
            if (DescricaoContemPalavrasChave(detalhes))
            {
                Mensagem = "Detalhes do serviço contêm palavras-chave proibidas.";
                return;
            }

            // Verificar disponibilidade do arquiteto ou designer
            if (!ArquitetoDesignerDisponivel(arquitetoDesigner, tipoServico))
            {
                Mensagem = $"O {arquitetoDesigner} não está disponível para este tipo de serviço.";
                return;
            }

            // Verificar se o trabalhador se apresenta naquela localidade (simulação)
            if (!TrabalhadorNaLocalidade(arquitetoDesigner, "LocalidadeDoCliente"))
            {
                Mensagem = $"{arquitetoDesigner} não está disponível nesta localidade.";
                return;
            }

            // Simulando o armazenamento em uma lista
            var pedido = new Pedido
            {
                TipoServico = tipoServico,
                Detalhes = detalhes,
                ArquitetoDesigner = arquitetoDesigner,
                Data = DateTime.Parse(data)
            };

            PedidoService.SalvarPedido(pedido);

            Mensagem = "Pedido criado com sucesso!";
        }

        private bool TipoServicoDisponivel(string tipoServico)
        {
            
            return TipoServicoService.TipoServicoDisponivel(tipoServico);
        }

        private bool DescricaoContemPalavrasChave(string descricao)
        {
            string[] palavrasChaveProibidas = { "orçamento", "materiais" };
            foreach (var palavra in palavrasChaveProibidas)
            {
                if (descricao.Contains(palavra, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ArquitetoDesignerDisponivel(string arquitetoDesigner, string tipoServico)
        {
            // Lógica para verificar se o arquiteto ou designer está disponível para o tipo de serviço
            // Você pode implementar a lógica de acordo com seus requisitos
            return true;
        }

        private bool TrabalhadorNaLocalidade(string arquitetoDesigner, string localidade)
        {
            // Lógica para verificar se o arquiteto ou designer está disponível na localidade
            // Você pode implementar a lógica de acordo com seus requisitos
            return true;
        }

        // Simulação de uma classe de serviço que interage com uma lista
        public class PedidoService
        {
            private static readonly List<Pedido> _bancoDeDados = new List<Pedido>();

            public static void SalvarPedido(Pedido pedido)
            {
                // Simula a adição do pedido à lista
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

        public class TipoServicoService
        {
            private static readonly List<string> _tiposDeServicoDisponiveis = new List<string>
            {
                "Tipo1",
                "Tipo2",
                "Tipo3",
                "Tipo4"
            };

            public static bool TipoServicoDisponivel(string tipoServico)
            {
                // Substitua pelo código real para verificar na sua lista
                return _tiposDeServicoDisponiveis.Contains(tipoServico, StringComparer.OrdinalIgnoreCase);
            }
        }
    }
}
