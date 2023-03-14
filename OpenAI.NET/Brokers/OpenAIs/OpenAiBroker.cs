using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAI.NET.Models.Configurations;

namespace OpenAI.NET.Brokers.OpenAIs
{
    internal partial class OpenAiBroker
    {
        private readonly ApiConfigurations apiConfigurations;
        public OpenAiBroker(ApiConfigurations apiConfigurations) => 
            this.apiConfigurations = apiConfigurations;
    }
}