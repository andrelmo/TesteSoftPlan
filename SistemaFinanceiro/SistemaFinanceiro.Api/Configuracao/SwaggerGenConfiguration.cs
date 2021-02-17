using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SistemaFinanceiro.Api.Configuracao
{
    public static class SwaggerGenConfiguration
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            var version = "v1";
            var title = "Api - Sistema Financeiro";

            if (!environment.IsEnvironment("Testing"))
            {
                version = configuration["Swagger:Version"];
                title = configuration["Swagger:Title"];
            }

            services.AddSwaggerGen(c => {
                c.SwaggerDoc(version, new Microsoft.OpenApi.Models.OpenApiInfo() { Title = title, Version = version });
            });

            return services;
        }

        public static IApplicationBuilder AddSwaggerConfigurationApp(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "post API V1");
            });

            return app;
        }
    }
}