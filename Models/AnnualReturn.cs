using Newtonsoft.Json;

namespace CHAPI.Models
{
    public class AnnualReturn
    {
        [JsonProperty("last_made_up_to")]
        public string last_made_up_to { get; set; }

        [JsonProperty("overdue")]
        public bool overdue { get; set; }
    }

}

