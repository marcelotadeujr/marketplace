﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Domain
{
    public class fidelityProgram
    {
        public string award { get; set; }
        public string award_item { get; set; }

        [JsonProperty("ref")]
        public string referencia { get; set; }
    }
}
