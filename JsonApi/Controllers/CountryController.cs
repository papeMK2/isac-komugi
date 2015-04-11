using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace JsonApi.Controllers
{
    public class CountryController : ApiController
    {
        public HttpResponseMessage Get()
        {

            //var path = HttpRuntime.AppDomainAppVirtualPath;

            //var path;
            //var json = JsonConvert.DeserializeObject<Models.Country>(HttpContext.Current.Server.MapPath("~/App_Data/country.json"));
            //return new string[] { "value1", "value2" };
            var path = HttpContext.Current.Server.MapPath("~/App_Data/country.json");
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            var stream = new FileStream(path, FileMode.Open);
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType =
                new MediaTypeHeaderValue("application/octet-stream");
            return result;
        }

        public HttpResponseMessage Get(int id)
        {

            //var path = HttpRuntime.AppDomainAppVirtualPath;

            //var path;
            //var json = JsonConvert.DeserializeObject<Models.Country>(HttpContext.Current.Server.MapPath("~/App_Data/country.json"));
            //return new string[] { "value1", "value2" };

            var filename = "";
            switch (id)
            {
                case 1:
                    filename = "country_location";
                    break;
                case 2:
                    filename = "country_location_distance";
                    break;
                case 3:
                    filename = "Wheat_data";
                    break;
                case 4:
                    filename = "Maize_data_all";
                    break;
            }

            try
            {
                var path = HttpContext.Current.Server.MapPath("~/App_Data/" + filename + ".json");
                HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
                var stream = new FileStream(path, FileMode.Open);
                result.Content = new StreamContent(stream);
                result.Content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");
                return result;
            }
            catch (Exception)
            {
                
            }
            return Get();
        }
    }
}
