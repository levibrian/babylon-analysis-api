using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Builders;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Builders.Interfaces;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Clients;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Clients.Interfaces;

namespace Babylon.Analysis.Api.Infrastructure.AlphaVantage.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterAlphaVantage(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IAlphaVantageUriBuilder, AlphaVantageUriBuilder>();
        serviceCollection.AddScoped<IAlphaVantageHttpClient, AlphaVantageHttpClient>();

        return serviceCollection;
    }
}