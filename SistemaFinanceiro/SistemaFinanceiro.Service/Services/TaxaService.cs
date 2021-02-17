using SistemaFinanceiro.Configuracoes;
using SistemaFinanceiro.Domain.Dtos.Taxa;
using SistemaFinanceiro.Domain.Interfaces.Services.Taxa;

namespace SistemaFinanceiro.Service.Services
{
    public class TaxaService: ITaxaService
    {
        public TaxaJurosDto GetTaxaJuros()
        {
            decimal _taxaJurosFixos = ConfiguracoesSistema.TaxaJuros;
            var _resultado = new TaxaJurosDto(_taxaJurosFixos);

            return (_resultado);
        }
    }
}