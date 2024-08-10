using AutoFixture;
using AutoFixture.Xunit2;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Builders;
using Babylon.Analysis.Api.Infrastructure.AlphaVantage.Models.Enums;
using FluentAssertions;
using Moq.AutoMock;

namespace Babylon.Analysis.Api.Tests.Infrastructure.AlphaVantage.Builders;

public class AlphaVantageUriBuilderTests
{
    private readonly Fixture fixture = new();
    private readonly AutoMocker autoMocker = new();
    private readonly AlphaVantageUriBuilder sut = new();

    [Theory]
    [InlineAutoData]
    public void Build_Should_Return_Formatted_Url(
        string ticker, 
        FunctionsEnum function)
    {
        // Arrange
        var expectedBaseUrl = new UriBuilder(Constants.Infrastructure.AlphaVantage.BaseUrl).ToString();
        
        // Act
        var url = sut.Build(ticker, function);
        
        // Assert
        url.Should().NotBeNullOrWhiteSpace();
        url.Should().Contain(expectedBaseUrl);
        url.Should().Contain(ticker);
        url.Should().Contain(Constants.Infrastructure.AlphaVantage.ApiKey);
    }
}