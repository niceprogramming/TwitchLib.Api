﻿using Newtonsoft.Json;

namespace TwitchLib.Api.Models.Helix.Streams
{
    public class LiveStreams
    {
        #region Total
        [JsonProperty(PropertyName = "_total")]
        public int Total { get; protected set; }
        #endregion
        #region Streams
        [JsonProperty(PropertyName = "streams")]
        public Stream[] Streams { get; protected set; }
        #endregion
    }
}