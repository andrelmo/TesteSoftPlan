using Moq;
using SistemaFinanceiro.Domain.Dtos.Taxa;
using SistemaFinanceiro.Domain.Interfaces.Services.Taxa;
using Xunit;

namespace SistemaFinanceiro.Api.Service.Test
{
    public class TesteTaxaService
    {
        private ITaxaService _service;
        private Mock<ITaxaService> _serviceMock;

        [Fact(DisplayName = "Executa o método GetTaxaJuros")]
        public void GetTaxaJuros()
        {
            var _taxaJurosEsperada = 0.01M;
            _serviceMock = new Mock<ITaxaService>();
            _serviceMock.Setup(m => m.GetTaxaJuros()).Returns(new TaxaJurosDto() { Valor = _taxaJurosEsperada } );
            _service = _serviceMock.Object;

            var _result = _service.GetTaxaJuros();

            Assert.NotNull(_result);
            Assert.Equal(_taxaJurosEsperada, _result.Valor);
        }
    }
}