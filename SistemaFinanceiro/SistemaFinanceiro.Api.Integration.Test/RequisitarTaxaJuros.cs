using Newtonsoft.Json;
using SistemaFinanceiro.Domain.Dtos.Taxa;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace SistemaFinanceiro.Api.Integration.Test
{
    public class RequisitarTaxaJuros : BaseIntegration
    {
        [Fact]
        public async Task GetTaxaJuros()
        {
            var _taxaJurosEsperada = 0.01M;
            
            response = await client.GetAsync($"{hostApi}GerenciarTaxa/taxaJuros");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var _jsonResult = await response.Content.ReadAsStringAsync();
            var _taxaRetornada = JsonConvert.DeserializeObject<TaxaJurosDto>(_jsonResult);
            Assert.NotNull(_taxaRetornada);
            Assert.Equal(_taxaRetornada.Valor, _taxaJurosEsperada);
        }
    }
}