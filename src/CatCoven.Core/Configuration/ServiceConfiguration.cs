﻿// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.Core.Configuration
{
    public class ServiceConfiguration : IServiceConfiguration
    {
        public string CosmosDatabase { get; set; }
        public string CosmosContainer { get; set; }
        public string CosmosEndpoint { get; set; }
        public string CosmosKey { get; set; }
    }
}