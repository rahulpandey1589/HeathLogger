using Business.Configuration.Common;
using Business.Models.Common;
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
        public async Task<ActionResult> GetAllTest(int? id = null)
        {
            var masters = await commonService.GetAllTestAsync(id);
            if (masters.Count > 0)
                return Ok(masters);

            return NoContent();
        }

        [Route("createNew")]
        [HttpPost]
        public async Task<ActionResult> CreateTest(TestMasterViewModelRequest testMaster)
        {
            if (ModelState.IsValid)
            {
                await commonService.InsertNewTest(new TestMasterDTO() 
                {
                    IsDeleted = false,
                    TestName = testMaster.TestName
                });
            }
            return Ok();
        }

    }
}
