﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAmiMacaronsBlazorWebAssembly.Shared
{
    public class Email
    {
        public string From { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty ;
        public string Body { get; set; } = string.Empty ;
    }
}
