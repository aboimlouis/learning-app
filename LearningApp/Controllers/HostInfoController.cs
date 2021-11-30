using LearningApp.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HostInfoController : ControllerBase
    {
        private readonly ILogger<HostInfoController> _logger;

        public HostInfoController(ILogger<HostInfoController> logger)
        {
            _logger = logger;
            
        }

        [HttpGet]
        public async Task<GetHostInfosResponse> Get()
        {
            GetHostInfosResponse response = new GetHostInfosResponse();

            try
            {
                string teste = "";
                
            }
            catch (Exception ex)
            {
                response.Info = ex.Message;
                return response;
            }

            return response;
        }
    }
}