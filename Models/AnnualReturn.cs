﻿using Newtonsoft.Json;

namespace CHAPI.Models
{
    public class AnnualReturn
    {
        [JsonProperty("last_made_up_to")]
        public string LastMadeUpTo { get; set; }

        [JsonProperty("overdue")]
        public bool Overdue { get; set; }
    }

}

