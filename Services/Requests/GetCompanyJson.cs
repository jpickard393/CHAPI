using System;
using CHAPI.Models;
namespace CHAPI.Services.Requests
{
    public class GetCompanyJson
    {
        private readonly IConfiguration _config;

        public GetCompanyJson(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<string> GetCompanyById(string companyNumber)
        {
            var company = string.Empty;
            if (!string.IsNullOrWhiteSpace(companyNumber))
            {
                var baseUrl = _config.GetValue<string>("baseUrl");
                var apiKey = _config.GetValue<string>("api-key");

                if (string.IsNullOrWhiteSpace(apiKey)) throw new Exception("APIKey Missing");
                if (string.IsNullOrWhiteSpace(baseUrl)) throw new Exception("API URL Missing");

                string path = baseUrl + "company/";

                CHAPIRequestJson request = new CHAPIRequestJson();
                company = await request.GetCompanyData(apiKey, path, companyNumber);
            }
            return company;
        }
    }
}

