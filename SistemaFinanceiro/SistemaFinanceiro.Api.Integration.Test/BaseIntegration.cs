using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;

namespace SistemaFinanceiro.Api.Integration.Test
{
    public abstract class BaseIntegration : IDisposable
    {
        public HttpClient client { get; private set; }
        public string hostApi { get; set; }
        public HttpResponseMessage response { get; set; }

        public BaseIntegration()
        {
            hostApi = "https://localhost:44346/";
            var builder = new WebHostBuilder()
               .UseEnvironment("Testing")
               .UseStartup<Startup>();
            var server = new TestServer(builder);

            client = server.CreateClient();
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}