using SistemaFinanceiro.Domain.Dtos.Git;

namespace SistemaFinanceiro.Domain.Interfaces.Services.GitHub
{
    public interface IGitHubService
    {
        GitHubDto GetShowmeTheCode();
    }
}
