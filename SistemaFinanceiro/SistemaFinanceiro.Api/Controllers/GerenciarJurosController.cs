using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiro.Domain.Dtos.Git;
using SistemaFinanceiro.Domain.Dtos.Juros;
using SistemaFinanceiro.Domain.Interfaces.Services.GitHub;
using SistemaFinanceiro.Domain.Interfaces.Services.Juros;

namespace SistemaFinanceiro.Api.Controllers
{
    [ApiController]
    public class GerenciarJurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;
        private readonly IGitHubService _gitHubService;

        public GerenciarJurosController(IJurosService jurosSevice, IGitHubService gitHubService)
        {
            _jurosService = jurosSevice;
            _gitHubService = gitHubService;
        }

        [HttpGet]
        [Route("GerenciarJuros/calculajuros/{valorInicial}/{tempo}")]
        [ProducesResponseType(typeof(ValorJurosDto), StatusCodes.Status200OK)]
        public IActionResult GetCalculaJuros([FromRoute]decimal valorInicial, int tempo)
        {
            return (Ok(_jurosService.GetCalculaJuros(valorInicial, tempo)));
        }

        [HttpGet]
        [Route("GerenciarJuros/showmethecode")]
        [ProducesResponseType(typeof(GitHubDto), StatusCodes.Status200OK)]
        public IActionResult GetShowmeTheCode()
        {
            return (Ok(_gitHubService.GetShowmeTheCode()));
        }
    }
}