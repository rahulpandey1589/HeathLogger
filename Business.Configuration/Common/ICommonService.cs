using Business.Models.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Configuration.Common
{
    public interface ICommonService
    {
        Task<IReadOnlyCollection<RelationShipMasterDTO>> GetAllRelationsAsync();

        Task<IReadOnlyCollection<TestMasterDTO>> GetAllTestAsync(int? id);

        Task<int> InsertNewTest(TestMasterDTO testMaster);
    }
}
