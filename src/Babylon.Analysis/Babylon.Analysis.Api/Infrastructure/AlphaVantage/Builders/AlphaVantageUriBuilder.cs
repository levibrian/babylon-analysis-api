using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Builders.Interfaces;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Models.Enums;
using static System.Web.HttpUtility;

namespace Babylon.Analysis.Api.Infrastructure.AlphaVantage.Builders;

public class AlphaVantageUriBuilder : IAlphaVantageUriBuilder
{
    public string Build(string ticker, FunctionsEnum function)
    {
        var uriBuilder = new UriBuilder(Constants.Infrastructure.AlphaVantage.BaseUrl);
        var query = ParseQueryString(uriBuilder.Query);

        var functionToQuery = function switch
        {
            FunctionsEnum.BalanceSheet => Constants.Infrastructure.AlphaVantage.BalanceSheetFunction,
            FunctionsEnum.CashFlow => Constants.Infrastructure.AlphaVantage.CashFlowFunction,
            FunctionsEnum.IncomeStatement => Constants.Infrastructure.AlphaVantage.IncomeStatementFunction,
            _ => throw new ArgumentOutOfRangeException(nameof(function), function, null)
        };

        query["function"] = functionToQuery; 
        query["symbol"] = ticker;
        query["apiKey"] = Constants.Infrastructure.AlphaVantage.ApiKey;

        uriBuilder.Query = query.ToString();
        return uriBuilder.ToString();
    }
}