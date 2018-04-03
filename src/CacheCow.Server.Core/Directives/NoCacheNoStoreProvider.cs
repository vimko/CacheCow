﻿using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace CacheCow.Server.Core
{
    /// <summary>
    /// Default cache directive provider
    /// </summary>
    public class NoCacheNoStoreProvider : ICacheDirectiveProvider
    {
        public CacheControlHeaderValue Get(HttpContext context)
        {
            return new CacheControlHeaderValue()
            {
                NoCache = true,
                NoStore = true
            };
        }
    }
}
