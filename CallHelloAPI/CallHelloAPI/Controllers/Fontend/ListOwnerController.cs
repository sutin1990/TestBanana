﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CallHelloAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CallHelloAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ListOwnerController : Controller
    {
        
        public async Task<ActionResult> Index()
        {
                        
            return View();
        }

    }
}