using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLoggerAPI.Controllers
{
    [Route("api/common")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        public CommonController()
        {

        }



        [Route("getRelations")]
        [HttpGet]
        public async Task<ActionResult> GetRelations()
        {

            return Ok();
        } 


    }
}
