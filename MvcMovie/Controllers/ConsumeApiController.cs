using MvcMovie.Constants;
using MvcMovie.Models;
using MvcMovie.RequestHandlers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class ConsumeApiController : Controller
    {

        IRequestHandler httpClientRequestHandler = new HttpClientRequestHandler();
        // GET: ConsumeApi
        public ActionResult Index()
        {

            var response = GetReleases(httpClientRequestHandler);

            //converting the json object into the the List objects
            var githubreleases = JsonConvert.DeserializeObject<GeneratedPixabay>(response);

            ViewBag.Message = githubreleases.hits[0].previewURL;
            return View();
        }

        public string GetReleases(IRequestHandler requestHandler)
        {
            return requestHandler.GetReleases(RequestConstants.tryUrl1);
        }

    }
}