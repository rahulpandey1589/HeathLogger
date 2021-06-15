using Business.Configuration;
using Microsoft.AspNetCore.Mvc;
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
            var relationMaster = await commonService.GetAllRelationsAsync();
            return Ok(relationMaster);
        }

        [Route("getAllTest")]
        [HttpGet]
        public async Task<ActionResult> GetAllTest()
        {
            var masters = await commonService.GetAllTestAsync();
            return Ok(masters);
        }
    }
}
