using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeyondLine.Model
{
    public class MarsRoverCamera
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rover_id")]
        public int RoverId { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }
}
