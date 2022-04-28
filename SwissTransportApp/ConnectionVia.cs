using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportApp
{
    public class ConnectionVia
    {
            [JsonProperty("from")]
            public ConnectionPoint From { get; set;}

            [JsonProperty("to")]
            public ConnectionPoint To { get; set; }

            [JsonProperty("duration")]
            public string Duration { get; set; }
        }
    }


