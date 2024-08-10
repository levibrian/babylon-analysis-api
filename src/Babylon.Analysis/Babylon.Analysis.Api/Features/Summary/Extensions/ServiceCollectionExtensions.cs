using Babylon.Analysis.Api.Features.Summary.Services;
using Babylon.Analysis.Api.Features.Summary.Services.Interfaces;

namespace Babylon.Analysis.Api.Features.Summary.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterSummaryFeature(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ISummaryService, SummaryService>();
    }
}