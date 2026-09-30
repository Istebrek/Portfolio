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
    IDetailsDtoService<ProjectDetailDto> detailsService) 
    : ControllerBase
{
    [HttpGet("summaries")]
    public async Task<IActionResult> GetAllSummaries([FromQuery] Language language)
    {
        return Ok(await summaryService.GetAllSummariesAsync(language));
    }

    [HttpGet("details")]
    public async Task<IActionResult> GetAllDetails([FromQuery] Language language)
    {
        return Ok(await detailsService.GetAllDetailsAsync(language));
    }

    [HttpGet("summary/{id}")]
    public async Task<IActionResult> GetSummaryById(string id, [FromQuery] Language language)
    {
        return Ok(await summaryService.GetSummaryByIdAsync(id, language));
    }

    [HttpGet("detail/{id}")]
    public async Task<IActionResult> GetDetailById(string id, [FromQuery] Language language)
    {
        return Ok(await detailsService.GetDetailsByIdAsync(id, language));
    }

    [HttpPost]
    public async Task<IActionResult> AddProject([FromBody] Project project)
    {
        entityService.Add(project);
        return Ok();
    }

    [HttpPatch("entity/{id}")]
    public async Task<IActionResult> UpdateProject(string id, [FromBody] Project project)
    {
        await entityService.UpdateAsync(id, project);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProject(string id)
    {
        await entityService.DeleteAsync(id);
        return NoContent();
    }

}