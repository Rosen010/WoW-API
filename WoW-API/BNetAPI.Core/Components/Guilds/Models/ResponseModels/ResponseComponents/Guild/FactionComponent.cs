﻿using Newtonsoft.Json;

namespace BNetAPI.Core.Components.Guilds.Models.ResponseModels.ResponseComponents
{
    public class FactionComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
