using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.Models;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OwnerController : Controller
    {
        List<Owner> owner = new List<Owner>();       
        // GET: api/Owner
        [HttpGet]
        public IActionResult Get()
        {            
            owner.Add(new Owner {HN = "002530", Name = "มัทริ บุญเจริญ",Phone="0946236355", Email = "user1@gmail.com" });
            owner.Add(new Owner {HN = "002512", Name = "ZACH PATZIG",Phone="0930914384", Email = "user2@gmail.com" });           

            return Json(owner);
        }        
    }
}
