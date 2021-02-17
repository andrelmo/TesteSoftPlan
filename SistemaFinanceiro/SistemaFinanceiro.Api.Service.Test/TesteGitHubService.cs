using Moq;
using SistemaFinanceiro.Domain.Dtos.Git;
using SistemaFinanceiro.Domain.Interfaces.Services.GitHub;
using Xunit;

namespace SistemaFinanceiro.Api.Service.Test
{
    public class TesteGitHubService
    {
        private IGitHubService _service;
        private Mock<IGitHubService> _serviceMock;

        [Fact(DisplayName = "Executa o método GetShowmeTheCode")]
        public void GetShowmeTheCode()
        {
            var _urlEsperada = Configuracoes.ConfiguracoesSistema.UrlGitHub;
            _serviceMock = new Mock<IGitHubService>();
            _serviceMock.Setup(m => m.GetShowmeTheCode()).Returns(new GitHubDto() {  Url = _urlEsperada });
            _service = _serviceMock.Object;

            var _result = _service.GetShowmeTheCode();

            Assert.NotNull(_result);
            Assert.Equal(_urlEsperada, _result.Url);
        }
    }
}