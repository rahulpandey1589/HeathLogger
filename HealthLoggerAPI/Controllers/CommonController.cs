using Business.Configuration.Common;
using HealthLoggerAPI.Models.Request;
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
        [Route("getAllTest/{id:int?}")]
        [HttpGet]
        public async Task<ActionResult> GetAllTest(int? id=null)
        {
            var masters = await commonService.GetAllTestAsync(id);
            return Ok(masters);
        }

        [Route("createNew")]
        [HttpPost]
        public async Task<ActionResult> CreateTest(TestMasterViewModel testMaster)
        {
            return Ok();
        }
             
    }
}
