// PublicarServicoModel.cs

using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

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

            // Verificar se os campos são nulos ou vazios
            if (string.IsNullOrWhiteSpace(tipoServico) ||
                string.IsNullOrWhiteSpace(descricaoServico) ||
                string.IsNullOrWhiteSpace(precoServico) ||
                string.IsNullOrWhiteSpace(negociavel))
            {
                Mensagem = "Por favor, preencha todos os campos do formulário.";
                return;
            }
            
            // Verificar se o preço é diferente de zero
            if (decimal.TryParse(precoServico, out decimal preco) && preco == 0)
            {
                Mensagem = "O preço do serviço não pode ser zero.";
                return;
            }

            // Restante do código para publicar o serviço
            var servicoService = new ServicoService();
            var sucesso = servicoService.PublicarServico(new Servico
            {
                TipoServico = tipoServico,
                DescricaoServico = descricaoServico,
                PrecoServico = decimal.Parse(precoServico),
                Negociavel = string.Equals(negociavel, "sim", StringComparison.OrdinalIgnoreCase)
            });

            if (sucesso)
            {
                Mensagem = "Serviço publicado com sucesso!";
            }
            else
            {
                Mensagem = "Erro ao publicar o serviço. Por favor, tente novamente.";
            }
        }

    }
}
