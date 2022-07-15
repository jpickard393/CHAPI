using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CHAPI.Controllers
{
    using Services.Requests;
    using Models;
    using Microsoft.AspNetCore.Cors;

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class CompanyController : ControllerBase
    {
        private readonly IConfiguration _config;
        public CompanyController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        [Route("/company/{companyNumber}")]
        public async Task<ActionResult<Company>> Get(string companyNumber)
        {
            if (!string.IsNullOrWhiteSpace(companyNumber))
            {
                GetCompany request = new GetCompany(_config);

                var company = await request.GetCompanyById(companyNumber);
                return company != null ? Ok(company) : NotFound();
            }
            return BadRequest("Company Number is Required");
        }
    }
}
