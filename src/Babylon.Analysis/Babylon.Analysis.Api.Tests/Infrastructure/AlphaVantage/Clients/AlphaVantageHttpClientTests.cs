using AutoFixture;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Clients;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Clients.Interfaces;
using Moq.AutoMock;

namespace Babylon.Analysis.Api.Tests.Infrastructure.AlphaVantage.Clients;

public class AlphaVantageHttpClientTests
{
    private readonly Fixture fixture = new();
    private readonly AutoMocker autoMocker = new();
    private readonly IAlphaVantageHttpClient sut;
    
    public AlphaVantageHttpClientTests()
    {
        sut = autoMocker.CreateInstance<AlphaVantageHttpClient>();
    }
}