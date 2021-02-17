using SistemaFinanceiro.Domain.Dtos.Juros;

namespace SistemaFinanceiro.Domain.Interfaces.Services.Juros
{
    public interface IJurosService
    {
        ValorJurosDto GetCalculaJuros(decimal valorInicial, int tempo);
    }
}
