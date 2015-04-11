using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Net.Http.Headers;

namespace JsonApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
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

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
