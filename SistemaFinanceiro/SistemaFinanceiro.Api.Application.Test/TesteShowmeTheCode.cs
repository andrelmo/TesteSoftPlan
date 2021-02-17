using Microsoft.AspNetCore.Mvc;
using Moq;
using SistemaFinanceiro.Api.Controllers;
using SistemaFinanceiro.Domain.Dtos.Git;
using SistemaFinanceiro.Domain.Interfaces.Services.GitHub;
using SistemaFinanceiro.Domain.Interfaces.Services.Juros;
using Xunit;

namespace SistemaFinanceiro.Api.Application.Test
{
    public class TesteShowmeTheCode
    {
        private GerenciarJurosController _controller;

        [Fact(DisplayName = "Executar o método ShowmeTheCode da Controlller GerenciarJurosController")]
        public void GetShowmetheCode()
        {
            var _serviceMockJuros = new Mock<IJurosService>();
            var _serviceMockGitHub = new Mock<IGitHubService>();
            var _urlEsperada = Configuracoes.ConfiguracoesSistema.UrlGitHub;

            _serviceMockGitHub.Setup(m => m.GetShowmeTheCode()).Returns(new GitHubDto() { Url = _urlEsperada });
            _controller = new GerenciarJurosController(_serviceMockJuros.Object, _serviceMockGitHub.Object);
            var _result = _controller.GetShowmeTheCode();

            Assert.True(_result is OkObjectResult);

            var _resultValue = ((OkObjectResult)_result).Value as GitHubDto;

            Assert.NotNull(_resultValue);
            Assert.Equal(_urlEsperada, _resultValue.Url);
        }
    }
}
