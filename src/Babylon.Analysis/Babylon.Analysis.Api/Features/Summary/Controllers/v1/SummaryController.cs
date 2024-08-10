using Babylon.Analysis.Api.Features.Summary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Babylon.Analysis.Api.Features.Summary.Controllers.v1;

[ApiController]
[Route("/api/v1/summary")]
public class SummaryController :  ControllerBase
{
    private readonly ISummaryService summaryService;
    private readonly ILogger<SummaryController> logger;

    public SummaryController(
        ISummaryService summaryService,
        ILogger<SummaryController> logger)
    {
        this.summaryService = summaryService;
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get(string ticker)
    {
        logger.LogInformation("GET - Summary");
        
        return Ok("Success");
    }
}