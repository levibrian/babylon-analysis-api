using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Builders.Interfaces;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Clients.Interfaces;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Models.Enums;

namespace Babylon.Analysis.Api.Infrastructure.AlphaVantage.Clients;

public class AlphaVantageHttpClient : IAlphaVantageHttpClient
{
    private readonly IAlphaVantageUriBuilder alphaVantageUriBuilder;

    public AlphaVantageHttpClient(IAlphaVantageUriBuilder alphaVantageUriBuilder)
    {
        this.alphaVantageUriBuilder = alphaVantageUriBuilder;
    }
    
    public async Task GetBalanceSheet(string ticker)
    {
        var url = alphaVantageUriBuilder.Build(ticker, FunctionsEnum.BalanceSheet);
    }
}