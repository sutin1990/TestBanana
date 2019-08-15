using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CallHelloAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CallHelloAPI.Controllers.API
{
    [Route("api/[controller]/[action]")]
    public class OwnerController : Controller
    {
        Helper callapi = new Helper();
        [HttpGet]
        public async Task<ActionResult> Transection()
        {

            List<Owner> owners = new List<Owner>();

            HttpClient client = callapi.InitializeClient();

            HttpResponseMessage res = await client.GetAsync("api/Owner/Get");

            
            if (res.IsSuccessStatusCode)
            {
               
                var result = res.Content.ReadAsStringAsync().Result;
                
                owners = JsonConvert.DeserializeObject<List<Owner>>(result);

            }

            return Json(owners);

        }
       
    }
}