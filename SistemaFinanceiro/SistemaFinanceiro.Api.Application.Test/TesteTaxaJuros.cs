using Microsoft.AspNetCore.Mvc;
using Moq;
using SistemaFinanceiro.Api.Controllers;
using SistemaFinanceiro.Domain.Dtos.Taxa;
using SistemaFinanceiro.Domain.Interfaces.Services.Taxa;
using Xunit;

namespace SistemaFinanceiro.Api.Application.Test
{
    public class TesteTaxaJuros
    {
        private GerenciarTaxaController _controller;

        [Fact(DisplayName = "Executar o método GetTaxaJuros da Controlller GerenciarTaxaController")]
        public void GetTaxaJuros()
        {
            var _serviceMockTaxa = new Mock<ITaxaService>();
            var _taxaEsperada = 0.01M;

            _serviceMockTaxa.Setup(m => m.GetTaxaJuros()).Returns(new TaxaJurosDto() {  Valor = _taxaEsperada });
            _controller = new GerenciarTaxaController(_serviceMockTaxa.Object);
            var _result = _controller.GetTaxaJuros();

            Assert.True(_result is OkObjectResult);

            var _resultValue = ((OkObjectResult)_result).Value as TaxaJurosDto;

            Assert.NotNull(_resultValue);
            Assert.Equal(_taxaEsperada, _resultValue.Valor);
        }
    }
}