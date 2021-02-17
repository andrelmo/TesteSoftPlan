namespace SistemaFinanceiro.Domain.Dtos.Taxa
{
    public class TaxaJurosDto
    {
        public decimal Valor { get; set; }

        public TaxaJurosDto()
        {
            Valor = 0;
        }

        public TaxaJurosDto(decimal valor)
        {
            Valor = valor;
        }
    }
}