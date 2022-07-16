using Newtonsoft.Json;

namespace CHAPI.Models
{
    public class ConfirmationStatement
    {
        [JsonProperty("next_due")]
        public string next_due { get; set; }

        [JsonProperty("next_made_up_to")]
        public string next_made_up_to { get; set; }

        [JsonProperty("overdue")]
        public bool overdue { get; set; }
    }

}

