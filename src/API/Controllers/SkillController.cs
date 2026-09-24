using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllSkills()
        {
            
            return Ok();
        }
    }
}
