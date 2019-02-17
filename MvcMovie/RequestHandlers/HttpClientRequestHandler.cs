using MvcMovie.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MvcMovie.RequestHandlers
{
    public class HttpClientRequestHandler : IRequestHandler
    {
        public string GetReleases(string url)
        {
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Add(RequestConstants.UserAgent, RequestConstants.UserAgentValue);

                var response = httpclient.GetStringAsync(new Uri(url)).Result;

                return response;
            }
        }
    }
}