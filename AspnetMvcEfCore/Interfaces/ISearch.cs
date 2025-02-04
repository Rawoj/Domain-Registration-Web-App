﻿using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainRegistrarWebApp.Models.Search
{
    public interface ISearch
    {
        public Task<DomainInfo> CheckAvailability(string domainName);
    }
}
