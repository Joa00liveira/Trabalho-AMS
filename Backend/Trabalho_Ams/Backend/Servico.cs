public class Servico
{
    private string tipoServico;
    private string detalhesServico;
    private DateTime dataServico;
    private static List<string> tiposDeServicoValidos = new List<string> { "Construção", "Design de Interiores", "Pintura", "Reparação" };
    
    // Construtor padrão
    public Servico()
    {
        tipoServico = string.Empty; // Inicializa como vazio por padrão
        detalhesServico = string.Empty;
        dataServico = DateTime.MinValue;
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

    public void ValidarTipoServico(string tipoServico)
    {
        // Verifica se o tipo de serviço é válido
        if (!tiposDeServicoValidos.Contains(tipoServico, StringComparer.OrdinalIgnoreCase))
        {
            throw new ArgumentException("Tipo de serviço inválido.", nameof(tipoServico));
        }
    }
    public Servico(string tipoServico, string detalhesServico, DateTime dataServico)
    {
        this.tipoServico = tipoServico;
        this.detalhesServico = detalhesServico;
        this.dataServico = dataServico;
    }

}
