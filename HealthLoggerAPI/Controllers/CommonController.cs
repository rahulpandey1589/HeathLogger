using Business.Configuration;
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
        private readonly ICommonService commonService;

        public CommonController(ICommonService commonService)
        {
            this.commonService = commonService;
        }

        [Route("getRelations")]
        [HttpGet]
        public async Task<ActionResult> GetRelations()
        {
            var allRelations = await commonService.GetAllRelationsAsync();
            return Ok();
        } 


    }
}
