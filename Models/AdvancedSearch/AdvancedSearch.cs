﻿using System;
using Newtonsoft.Json;
namespace CHAPI.Models.AdvancedSearch
{
    public class AdvancedSearch
    {
        [JsonProperty("etag")]
        public string? Etag { get; set; }

        [JsonProperty("top_hit")]
        public TopHit? TopHit { get; set; }

        // Item is of type item in JSON
        [JsonProperty("items")]
        public List<Company>? Items { get; set; }

        [JsonProperty("kind")]
        public string? Kind { get; set; }

        [JsonProperty("hits")]
        public int? Hits { get; set; }
    }
}

