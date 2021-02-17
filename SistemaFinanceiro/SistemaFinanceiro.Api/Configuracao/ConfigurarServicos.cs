using Microsoft.Extensions.DependencyInjection;
using SistemaFinanceiro.Domain.Interfaces.Services.GitHub;
using SistemaFinanceiro.Domain.Interfaces.Services.Juros;
using SistemaFinanceiro.Domain.Interfaces.Services.Taxa;
using SistemaFinanceiro.Service.Services;

namespace SistemaFinanceiro.Api.Configuracao
{
    public static class ConfigurarServicos
    {
        public static void AdicionarServicos(this IServiceCollection servicos)
        {
            servicos.AddTransient<IJurosService, JurosService>();
            servicos.AddTransient<IGitHubService, GitHubService>();
            servicos.AddTransient<ITaxaService, TaxaService>();
        }
    }
}