using MudBlazor;

namespace afya_admin.Data;

public class KpiItem
{
    public string Titulo { get; set; } = "";
    public string Valor { get; set; } = "";
    public string Variacao { get; set; } = "";
    public bool IsPositivo { get; set; } = true;
    public double[] SparklineData { get; set; } = Array.Empty<double>();
    public Color Cor { get; set; } = Color.Primary;
}

public class ProjetoPerformance
{
    public string Nome { get; set; } = "";
    public int Progresso { get; set; }
    public string TarefasInfo { get; set; } = "";
    public Color Cor { get; set; } = Color.Primary;
}

public class AtividadeRecente
{
    public string Iniciais { get; set; } = "";
    public string Nome { get; set; } = "";
    public string Acao { get; set; } = "";
    public string Tempo { get; set; } = "";
    public Color CorAvatar { get; set; } = Color.Primary;
}

public class ProjetoDetalhe
{
    public string Nome { get; set; } = "";
    public string Cliente { get; set; } = "";
    public string Responsavel { get; set; } = "";
    public string IniciaisResponsavel { get; set; } = "";
    public string Status { get; set; } = "";
    public Color CorStatus { get; set; } = Color.Primary;
    public int Progresso { get; set; }
    public string Prazo { get; set; } = "";
}

public static class DashboardMockData
{
    public static List<KpiItem> ObterKpis() => new()
    {
        new KpiItem { Titulo = "Receita", Valor = "R$ 248.500", Variacao = "+12,5%", IsPositivo = true, SparklineData = new double[] { 10, 15, 12, 18, 22, 25 }, Cor = Color.Success },
        new KpiItem { Titulo = "Usuários Ativos", Valor = "12.842", Variacao = "+8,2%", IsPositivo = true, SparklineData = new double[] { 8, 12, 10, 14, 16, 20 }, Cor = Color.Secondary },
        new KpiItem { Titulo = "Novos Clientes", Valor = "384", Variacao = "+16,6%", IsPositivo = true, SparklineData = new double[] { 5, 8, 12, 10, 15, 18 }, Cor = Color.Info },
        new KpiItem { Titulo = "Projetos Ativos", Valor = "27", Variacao = "-2,4%", IsPositivo = false, SparklineData = new double[] { 20, 18, 16, 15, 14, 12 }, Cor = Color.Warning }
    };

    public static List<ProjetoPerformance> ObterPerformanceProjetos() => new()
    {
        new ProjetoPerformance { Nome = "Website Corporativo", Progresso = 83, TarefasInfo = "34 de 41 tarefas", Cor = Color.Primary },
        new ProjetoPerformance { Nome = "App Mobile", Progresso = 68, TarefasInfo = "27 de 41 tarefas", Cor = Color.Secondary },
        new ProjetoPerformance { Nome = "Migração Cloud", Progresso = 92, TarefasInfo = "46 de 50 tarefas", Cor = Color.Success },
        new ProjetoPerformance { Nome = "Sistema ERP", Progresso = 54, TarefasInfo = "27 de 50 tarefas", Cor = Color.Warning }
    };

    public static List<AtividadeRecente> ObterAtividadesRecentes() => new()
    {
        new AtividadeRecente { Iniciais = "MS", Nome = "Mariana Souza", Acao = "adicionou um novo cliente", Tempo = "há 5 minutos", CorAvatar = Color.Primary },
        new AtividadeRecente { Iniciais = "CL", Nome = "Carlos Lima", Acao = "finalizou a revisão Website Corporativo", Tempo = "há 18 minutos", CorAvatar = Color.Success },
        new AtividadeRecente { Iniciais = "AM", Nome = "Ana Martins", Acao = "publicou um novo relatório", Tempo = "há 45 minutos", CorAvatar = Color.Secondary },
        new AtividadeRecente { Iniciais = "JS", Nome = "João Silva", Acao = "atualizou as permissões do sistema", Tempo = "há 1 hora", CorAvatar = Color.Warning }
    };

    public static List<ProjetoDetalhe> ObterProjetosRecentes() => new()
    {
        new ProjetoDetalhe { Nome = "Portal Institucional", Cliente = "TechCorp", Responsavel = "Mariana Souza", IniciaisResponsavel = "MS", Status = "Em andamento", CorStatus = Color.Info, Progresso = 72, Prazo = "25 Set" },
        new ProjetoDetalhe { Nome = "Aplicativo Mobile", Cliente = "Nova Digital", Responsavel = "Carlos Lima", IniciaisResponsavel = "CL", Status = "Em revisão", CorStatus = Color.Warning, Progresso = 80, Prazo = "28 Set" },
        new ProjetoDetalhe { Nome = "Migração Cloud", Cliente = "CloudSystems", Responsavel = "Ana Martins", IniciaisResponsavel = "AM", Status = "Concluído", CorStatus = Color.Success, Progresso = 100, Prazo = "20 Set" },
        new ProjetoDetalhe { Nome = "Sistema ERP", Cliente = "Alpha Group", Responsavel = "João Silva", IniciaisResponsavel = "JS", Status = "Em andamento", CorStatus = Color.Info, Progresso = 48, Prazo = "15 Out" }
    };
}