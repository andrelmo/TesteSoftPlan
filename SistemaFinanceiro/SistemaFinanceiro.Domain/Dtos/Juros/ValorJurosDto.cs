namespace SistemaFinanceiro.Domain.Dtos.Juros
{
    public class ValorJurosDto
    {
        public decimal Valor { get; set; }

        public ValorJurosDto()
        {
            Valor = 0;
        }

        public ValorJurosDto(decimal valor)
        {
            Valor = valor;
        }
    }
}
