using LearningApp.Domain.DTOs.User.Responses;
using LearningApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LearningController : ControllerBase
    {
        private readonly ILogger<LearningController> _logger;
        private IGetCompleteUserService _getCompleteUserService { get; set; }

        public LearningController(ILogger<LearningController> logger, IGetCompleteUserService getCompleteUserService)
        {
            _logger = logger;
            _getCompleteUserService = getCompleteUserService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CompleteUserDTO>>> Get()
        {
            return Ok(await _getCompleteUserService.GetCompleteUser());
        }
    }
}