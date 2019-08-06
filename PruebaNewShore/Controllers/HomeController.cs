using Newtonsoft.Json;
using PruebaNewShore.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaNewShore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public string GetBuscarVuelos()
        {

            RestSharp.RestClient client = new RestClient("http://testapi.vivaair.com/otatest/");


            RestSharp.RestRequest request = new RestRequest
            {

                Resource = "api/values",
                Method = RestSharp.Method.POST
            };

            request.AddParameter("Origin", "BOG");
            request.AddParameter("Destination", "CTG");
            request.AddParameter("From", "2019-08-06");

            var response = client.Execute(request);
            var contenido=response.Content;

            char[] charsToTrim = { '*', ' ', '\'' };
            string result = contenido.Trim(charsToTrim);

            return result;
    }
         
        public ActionResult Index() {
            GetBuscarVuelos();
            return View();
        
        }

        public ActionResult BuscarVuelo()
        {

            IList<Flight> lista = JsonConvert.DeserializeObject<IList<Flight>>(GetBuscarVuelos());
            return View(lista.ToList());

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
    }
}