﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DegustaAi.Domain
{
    public class response_base
    {
        public string status { get; set; }
        public string code { get; set; }
        public string message { get; set; }
    }
}
