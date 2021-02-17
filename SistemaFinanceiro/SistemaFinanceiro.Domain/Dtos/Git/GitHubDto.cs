namespace SistemaFinanceiro.Domain.Dtos.Git
{
    public class GitHubDto
    {
        public string Url { get; set; }

        public GitHubDto()
        {
            Url = string.Empty;
        }

        public GitHubDto(string url)
        {
            Url = url;
        }
    }
}
