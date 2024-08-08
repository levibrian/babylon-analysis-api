using Microsoft.AspNetCore.Mvc;

namespace Babylon.Analysis.Api.Features.Summary.Controllers.v1;

[ApiController]
[Route("/api/v1/summary")]
public class SummaryController :  ControllerBase
{
    private readonly ILogger<SummaryController> logger;

    public SummaryController(ILogger<SummaryController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get(string ticker)
    {
        logger.LogInformation("GET - Summary");
        
        return Ok();
    }
}