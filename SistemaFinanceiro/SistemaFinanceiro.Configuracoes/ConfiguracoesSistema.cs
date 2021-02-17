namespace SistemaFinanceiro.Configuracoes
{
    public static class ConfiguracoesSistema
    {
        public static decimal TaxaJuros { get; set; }
        public static string UrlGitHub { get; set; }

        static ConfiguracoesSistema()
        {
            TaxaJuros = 0.01M;
            UrlGitHub = "https://github.com/andrelmo/TesteSoftPlan.git";
        }
    }
}