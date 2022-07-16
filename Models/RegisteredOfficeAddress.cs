using Newtonsoft.Json;

namespace CHAPI.Models
{
    public class RegisteredOfficeAddress
    {
        [JsonProperty("postal_code")]
        public string? postal_code { get; set; }

        [JsonProperty("region")]
        public string? region { get; set; }

        [JsonProperty("address_line_1")]
        public string? address_line_1 { get; set; }

        [JsonProperty("address_line_2")]
        public string? address_line_2 { get; set; }

        [JsonProperty("locality")]
        public string? locality { get; set; }

        [JsonProperty("country")]
        public string? country { get; set; }
    }

}

