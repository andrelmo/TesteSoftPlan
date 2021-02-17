using Microsoft.Extensions.Configuration;
using SistemaFinanceiro.Domain.Dtos.Git;
using SistemaFinanceiro.Domain.Interfaces.Services.GitHub;

namespace SistemaFinanceiro.Service.Services
{
    public class GitHubService: IGitHubService
    {
        private readonly IConfiguration _configuracao;

        public GitHubService(IConfiguration configuracao)
        {
            _configuracao = configuracao;
        }

        public GitHubDto GetShowmeTheCode()
        {
            var _url = Configuracoes.ConfiguracoesSistema.UrlGitHub;
            var _resultado = new GitHubDto(_url);

            return (_resultado);
        }
    }
}