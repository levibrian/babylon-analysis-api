using Babylon.Analysis.Api.Features.Summary.Extensions;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Extensions;

namespace Babylon.Analysis.Api.Features.Startup.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterFeatures(this IServiceCollection serviceCollection)
    {
        serviceCollection.RegisterSummaryFeature();
        serviceCollection.RegisterAlphaVantage();
    }
}