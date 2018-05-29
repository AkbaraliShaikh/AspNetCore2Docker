using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore2Docker.Controllers
{
    [Route("api/[controller]")]
    public partial class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Info("Asp.NEt Core 2.0 on Linux", "Docker makes life easy"));
        }
    }
}
