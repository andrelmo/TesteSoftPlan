using Moq;
using SistemaFinanceiro.Domain.Dtos.Juros;
using SistemaFinanceiro.Domain.Interfaces.Services.Juros;
using Xunit;

namespace SistemaFinanceiro.Api.Service.Test
{
    public class TesteJurosService
    {
        private IJurosService _service;
        private Mock<IJurosService> _serviceMock;

        [Fact(DisplayName = "Executa o método GetCalculaJuros")]
        public void GetCalculaJuros()
        {
            var _valorInicial = 100M;
            var _tempo = 5;
            var _valorEsperado = 105.1M;

            _serviceMock = new Mock<IJurosService>();
            _serviceMock.Setup(m => m.GetCalculaJuros(_valorInicial, _tempo)).Returns(new ValorJurosDto() { Valor = _valorEsperado});
            _service = _serviceMock.Object;

            var _result = _service.GetCalculaJuros(_valorInicial, _tempo);

            Assert.NotNull(_result);
            Assert.Equal(_valorEsperado, _result.Valor);
        }
    }
}