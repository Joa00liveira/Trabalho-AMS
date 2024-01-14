using Backend;

public class Trabalhador
{

    private int id;
    private string nome;
    private string especializacao;
    private string email;

    // Construtor padrão
    public Trabalhador()
    {
        id = 0;
        nome = string.Empty;
        especializacao = string.Empty;
        email = string.Empty;
    }

    // Construtor com parâmetros
    public Trabalhador(int id, string nome, string email, string especializacao)
    {
        this.id = id;
        this.nome = nome;
        this.email = email;
        this.especializacao = especializacao;
    }

    public int Id
    {
        get { return id; }
    }

    public string Nome
    {
        get { return nome; }
    }

    public string Especializacao
    {
        get { return especializacao; }
    }

    public string Email
    {
        get { return email; }
    }

    public int PublicarServico(string tipoServico, string detalhesServico, DateTime dataServico, int estado, int preco, bool precoNegociavel)
    {
        Servico s = new Servico(tipoServico, detalhesServico, dataServico, estado, preco, precoNegociavel);
        //ADICIONAR SERVIÇO À LISTA DE SERVIÇOS (CLASSE SERVIÇOS POR CRIAR)
        return 0;
    }
}