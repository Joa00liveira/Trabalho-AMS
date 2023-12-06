using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Projeto.Pages
{
    public class PublicarServicoModel : PageModel
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
            var descricaoServico = Request.Form["descricaoServico"];
            var precoServico = Request.Form["precoServico"];
            var negociavel = Request.Form["negociavel"];

            // Verifica se os campos são nulos ou vazios
            if (string.IsNullOrWhiteSpace(tipoServico) ||
                string.IsNullOrWhiteSpace(descricaoServico) ||
                string.IsNullOrWhiteSpace(precoServico) ||
                string.IsNullOrWhiteSpace(negociavel))
            {
                Mensagem = "Por favor, preencha todos os campos do formulário.";
                return;
            }

            // Simulando o armazenamento em um banco de dados
            var servicoService = new ServicoService();
            servicoService.PublicarServico(new Servico
            {
                TipoServico = tipoServico,
                DescricaoServico = descricaoServico,
                PrecoServico = decimal.Parse(precoServico),
                Negociavel = string.Equals(negociavel, "sim", StringComparison.OrdinalIgnoreCase)
            });

            Mensagem = "Serviço publicado com sucesso!";
        }

        // Simulação de uma classe de serviço que interage com um banco de dados
        public class ServicoService
        {
            private static readonly List<Servico> _bancoDeDados = new List<Servico>();

            public void PublicarServico(Servico servico)
            {
                // Simula a adição do serviço ao banco de dados
                _bancoDeDados.Add(servico);
            }
        }

        // Simulação da entidade Servico
        public class Servico
        {
            public string TipoServico { get; set; }
            public string DescricaoServico { get; set; }
            public decimal PrecoServico { get; set; }
            public bool Negociavel { get; set; }
        }
    }
}
