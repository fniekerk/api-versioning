using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.Elasticsearch;
using Serilog.Sinks.Grafana.Loki;
using Serilog.Sinks.Grafana.Loki.HttpClients;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.Logging
{
    public static class SeriLogger
    {
        public static Action<HostBuilderContext, LoggerConfiguration> Configure =>
           (context, configuration) =>
           {
               configuration.Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .WriteTo.Console()
                .WriteTo.Elasticsearch(
                    new ElasticsearchSinkOptions(new Uri(context.Configuration["ElasticConfiguration:Uri"]))
                    {
                        IndexFormat = $"applogs-{context.Configuration["ApplicationName"]}-logs-{context.HostingEnvironment.EnvironmentName?.ToLower().Replace(".", "-")}-{DateTime.UtcNow:yyyy-MM}",
                        AutoRegisterTemplate = true,
                        //NumberOfShards = 2,
                        //NumberOfReplicas = 1
                    }
                 )
                .WriteTo.GrafanaLoki(context.Configuration["GrafanaLokiConfiguration:Uri"])
                .Enrich.WithProperty("Environment", context.HostingEnvironment.EnvironmentName)
                .ReadFrom.Configuration(context.Configuration);
           };

        //public class CustomHttpClient : BaseLokiHttpClient
        //{
        //    public override Task<HttpResponseMessage> PostAsync(string requestUri, Stream contentStream)
        //    {
        //        return base.PostAsync(requestUri, contentStream);
        //    }
        //}
    }
}
