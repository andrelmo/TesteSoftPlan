using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiro.Domain.Dtos.Taxa;
using SistemaFinanceiro.Domain.Interfaces.Services.Taxa;

namespace SistemaFinanceiro.Api.Controllers
{
    [ApiController]
    public class GerenciarTaxaController : ControllerBase
    {
        private readonly ITaxaService _taxaService;

        public GerenciarTaxaController(ITaxaService taxaService)
        {
            _taxaService = taxaService;
        }

        [HttpGet]
        [Route("GerenciarTaxa/taxaJuros")]
        [ProducesResponseType(typeof(TaxaJurosDto),StatusCodes.Status200OK)]
        public IActionResult GetTaxaJuros()
        {
            return (Ok(_taxaService.GetTaxaJuros()));
        }
    }
}