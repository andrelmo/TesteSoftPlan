using Microsoft.AspNetCore.Mvc;
using Moq;
using SistemaFinanceiro.Api.Controllers;
using SistemaFinanceiro.Domain.Dtos.Juros;
using SistemaFinanceiro.Domain.Interfaces.Services.GitHub;
using SistemaFinanceiro.Domain.Interfaces.Services.Juros;
using Xunit;

namespace SistemaFinanceiro.Api.Application.Test
{
    public class TesteCalculaJuros
    {
        private GerenciarJurosController _controller;

        [Fact(DisplayName = "Executar o método GetCalcularJuros da Controlller GerenciarJurosController")]
        public void GetCalculaJuros()
        {
            var _serviceMockJuros = new Mock<IJurosService>();
            var _serviceMockGitHub = new Mock<IGitHubService>();
            var _valorInicial = 100M;
            var _tempo = 5;
            decimal _valorEsperado = 105.1M;

            _serviceMockJuros.Setup(m => m.GetCalculaJuros(_valorInicial, _tempo)).Returns(new ValorJurosDto() { Valor = _valorEsperado });
            _controller = new GerenciarJurosController(_serviceMockJuros.Object, _serviceMockGitHub.Object);
            var _result = _controller.GetCalculaJuros(_valorInicial, _tempo);

            Assert.True(_result is OkObjectResult);

            var _resultValue = ((OkObjectResult)_result).Value as ValorJurosDto;

            Assert.NotNull(_resultValue);
            Assert.Equal(_valorEsperado, _resultValue.Valor);
        }
    }
}