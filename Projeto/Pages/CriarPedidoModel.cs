using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projeto.Pages
{
    public class CriarPedidoModel : PageModel
    {
        public void OnGet()
        {
            // Lógica para processar a solicitação GET, se necessário
        }

        public void OnPost()
        {
            // Lógica para processar a solicitação POST (envio do formulário)
            // Você pode acessar os dados do formulário usando o objeto Request.Form
            var tipoServico = Request.Form["TipoServico"];
            var detalhes = Request.Form["Detalhes"];
            var arquitetoDesigner = Request.Form["ArquitetoDesigner"];
            var data = Request.Form["Data"];

            // Aqui você pode realizar ações com os dados, por exemplo, salvá-los no banco de dados
        }
    }
}


