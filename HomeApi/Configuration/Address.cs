﻿using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Security.AccessControl;

namespace HomeApi.Configuration
{
    public class Address
    {
        public int House {  get; set; }
        public int Building { get; set; }
        public string Street { get; set; }
    }
}
