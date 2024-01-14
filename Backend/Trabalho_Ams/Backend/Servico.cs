public class Servico
{
    private string tipoServico;
    private string detalhesServico;
    private DateTime dataServico;
    private int estado;
    private int preco;
    private bool precoNegociavel;
    public static List<string> tiposDeServicoValidos = new List<string> { "Construção", "Design de Interiores", "Pintura", "Reparação" };



    public enum EEstado
    {
        Enviado = 0,
        Desativado = -1,
        Ativo = 1,
        Em_Verificacao = 2,
        Concluido = 3
    }

    // Construtor padrão
    public Servico()
    {
        tipoServico = string.Empty; // Inicializa como vazio por padrão
        detalhesServico = string.Empty;
        dataServico = DateTime.MinValue;
        estado = -1;
        preco = 0;
        precoNegociavel = false;
    }


    public string TipoServico
    {
        get { return tipoServico; }
    }

    public string DetalhesServico
    {
        get { return detalhesServico; }
    }


    public DateTime DataServico
    {
        get { return dataServico; }
    }

    public int Estado { get => estado; set => estado = value; }
    public int Preco { get => preco; set => preco = value; }
    public bool PrecoNegociavel { get => precoNegociavel; set => precoNegociavel = value; }

    public void ValidarTipoServico(string tipoServico)
    {
        // Verifica se o tipo de serviço é válido
        if (!tiposDeServicoValidos.Contains(tipoServico, StringComparer.OrdinalIgnoreCase))
        {
            throw new ArgumentException("Tipo de serviço inválido.", nameof(tipoServico));
        }
    }
    public Servico(string tipoServico, string detalhesServico, DateTime dataServico, int estado, int preco, bool precoNegociavel)
    {
        this.tipoServico = tipoServico;
        this.detalhesServico = detalhesServico;
        this.dataServico = dataServico;
        this.estado = estado;
        this.preco = preco;
        this.precoNegociavel = precoNegociavel;
    }
}
