using Newtonsoft.Json;

namespace CHAPI.Models
{
    public class ConfirmationStatement
    {
        [JsonProperty("next_due")]
        public string NextDue { get; set; }

        [JsonProperty("next_made_up_to")]
        public string NextMadeUpTo { get; set; }

        [JsonProperty("overdue")]
        public bool Overdue { get; set; }
    }

}

