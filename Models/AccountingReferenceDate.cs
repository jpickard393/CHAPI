using Newtonsoft.Json;

namespace CHAPI.Models
{
    public class AccountingReferenceDate
    {
        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }
    }

}

