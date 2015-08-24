using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeyOfertasWC.Models;
using Newtonsoft.Json;

namespace HeyOfertasWC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EdealsByID(String _id)
        {
            var client = new RestClient("http://edeals.do:4000");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("/api/deals/{id}", Method.GET);
            request.AddUrlSegment("id", _id); // replaces matching token in request.Resource

            
            // execute the request
            RestResponse<Deals> response = (RestResponse<Deals>)client.Execute<Deals>(request);
            var content = response.Content; // raw content as string
            var deal = JsonConvert.DeserializeObject<List<Deals>>(content)[0];

            ViewBag.deal = deal;
            ViewBag.des = deal.description;
            ViewBag.fullurl = deal.source.url + deal.url;

            return View();
        }

    }
}