using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Application.IServices;
using Domain.Entities;
using Shared.Models;
using Shared.Lists;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectController
    (IEntityService<Project> entityService, 
    ISummaryDtoService<ProjectSummaryDto> summaryService, 
    IDetailsDtoService<ProjectDetailsDto> detailsService) 
    : ControllerBase
{
    [HttpGet("summaries")]
    public async Task<IActionResult> GetAllSummaries([FromQuery] Language language)
    {
        return Ok(await summaryService.GetAllSummariesAsync(language));
    }

    [HttpPost]
    public async Task<IActionResult> AddProject([FromBody]Project project)
    {
        entityService.Add(project);
        return Ok();
    }
}