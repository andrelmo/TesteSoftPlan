using Newtonsoft.Json;
using SistemaFinanceiro.Domain.Dtos.Git;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace SistemaFinanceiro.Api.Integration.Test
{
    public class RequisitarGitHubUrl : BaseIntegration
    {
        [Fact]
        public async Task GetShowmetheCode()
        {
            var _urlEsperada = Configuracoes.ConfiguracoesSistema.UrlGitHub;

            response = await client.GetAsync($"{hostApi}GerenciarJuros/showmethecode");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var _jsonResult = await response.Content.ReadAsStringAsync();
            var _urlRetornada = JsonConvert.DeserializeObject<GitHubDto>(_jsonResult);

            Assert.NotNull(_urlRetornada);
            Assert.Equal(_urlRetornada.Url, _urlEsperada);
        }
    }
}