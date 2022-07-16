using System;
using Newtonsoft.Json;
namespace CHAPI.Models.AdvancedSearch
{
    public class TopHit
    {
        [JsonProperty("company_name")]
        public string? company_name { get; set; }

        [JsonProperty("company_number")]
        public string? company_number { get; set; }

        [JsonProperty("company_status")]
        public string? company_status { get; set; }

        [JsonProperty("company_type")]
        public string? company_type { get; set; }

        [JsonProperty("kind")]
        public string? kind { get; set; }

        [JsonProperty("links")]
        public Links? links { get; set; }

        [JsonProperty("date_of_creation")]
        public string? date_of_creation { get; set; }

        [JsonProperty("registered_office_address")]
        public RegisteredOfficeAddress? registered_office_address { get; set; }

        [JsonProperty("sic_codes")]
        public List<string>? sic_codes { get; set; }
    }
}

