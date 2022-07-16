using Newtonsoft.Json;

namespace CHAPI.Models
{
    public class LastAccounts
    {
        [JsonProperty("made_up_to")]
        public string made_up_to { get; set; }

        [JsonProperty("period_start_on")]
        public string period_start_on { get; set; }

        [JsonProperty("period_end_on")]
        public string period_end_on { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }
    }

}

