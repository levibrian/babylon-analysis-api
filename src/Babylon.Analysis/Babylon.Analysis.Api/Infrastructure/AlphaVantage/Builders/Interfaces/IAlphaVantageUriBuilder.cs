using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Models.Enums;

namespace Babylon.Analysis.Api.Infrastructure.AlphaVantage.Builders.Interfaces;

public interface IAlphaVantageUriBuilder
{
    string Build(string ticker, FunctionsEnum function);
}