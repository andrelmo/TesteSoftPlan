using Newtonsoft.Json;
using SistemaFinanceiro.Domain.Dtos.Juros;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace SistemaFinanceiro.Api.Integration.Test
{
    public class RequisitarCalcularJuros : BaseIntegration
    {
        [Fact]
        public async Task GetCalculaJuros()
        {
            var _valorInicial = 100M;
            var _tempo = 5;
            var _valorEsperado = 105.1M;

            response = await client.GetAsync($"{hostApi}GerenciarJuros/calculajuros/{_valorInicial}/{_tempo}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var _jsonResult = await response.Content.ReadAsStringAsync();
            var _jurosRetornados = JsonConvert.DeserializeObject<ValorJurosDto>(_jsonResult);

            Assert.NotNull(_jurosRetornados);
            Assert.Equal(_jurosRetornados.Valor, _valorEsperado);
        }
    }
}