using SistemaFinanceiro.Domain.Dtos.Taxa;

namespace SistemaFinanceiro.Domain.Interfaces.Services.Taxa
{
    public interface ITaxaService
    {
        TaxaJurosDto GetTaxaJuros();
    }
}