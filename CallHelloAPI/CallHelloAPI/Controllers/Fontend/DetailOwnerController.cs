using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CallHelloAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CallHelloAPI.Controllers.Fontend
{
    public class DetailOwnerController : Controller
    {
        Helper callapi = new Helper();
        public async Task<IActionResult> Index(string id)
        {            
            List<Owner> owners = new List<Owner>();

            HttpClient client = callapi.InitializeClient();

            HttpResponseMessage res = await client.GetAsync("api/Owner/Get");

              
            if (res.IsSuccessStatusCode)
            {
                  
                var result = res.Content.ReadAsStringAsync().Result;
                
                owners = JsonConvert.DeserializeObject<List<Owner>>(result);

            }
            var obj_owners = owners.SingleOrDefault(s => s.HN == id);
            return View(obj_owners);
            
        }
    }
}