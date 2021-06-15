using Business.Models;
using Business.Models.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Configuration
{
    public interface ICommonService
    {
        Task<IReadOnlyCollection<RelationShipMasterDTO>> GetAllRelationsAsync();

        Task<IReadOnlyCollection<TestMasterDTO>> GetAllTestAsync();
    }
}
