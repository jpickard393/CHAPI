using Microsoft.AspNetCore.Mvc;

namespace CHAPI.Controllers
{
    using Services.Requests;   
    using Microsoft.AspNetCore.Cors;

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class AdvancedSearchController : ControllerBase
    {
        private readonly IConfiguration _config;
        public AdvancedSearchController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        [Route("/advanced-search/companies/{searchParam}")]
        public async Task<IActionResult> Index(string searchParam)
        {
            if (!string.IsNullOrWhiteSpace(searchParam))
            {
                var request = new GetAdvancedSearch(_config);
                var searchView = await request.GetAdvancedSearchAsync(searchParam);

                return searchView != null ? Ok(searchView) : NotFound();
            }
            return BadRequest("Company Number is Required");
        }
    }
}


