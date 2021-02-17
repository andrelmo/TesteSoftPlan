using SistemaFinanceiro.Configuracoes;
using SistemaFinanceiro.Domain.Dtos.Juros;
using SistemaFinanceiro.Domain.Interfaces.Services.Juros;
using System;

namespace SistemaFinanceiro.Service.Services
{
    public class JurosService: IJurosService
    {
        public ValorJurosDto GetCalculaJuros(decimal valorInicial, int tempo)
        {
            var _parte1 = Convert.ToDouble(1 + ConfiguracoesSistema.TaxaJuros);
            var _parte2 = Math.Pow(_parte1, tempo);
            var _valorParcial = Math.Round(valorInicial * (decimal)_parte2, 2);
            var _resultado = new ValorJurosDto(_valorParcial);

            return (_resultado);
        }
    }
}