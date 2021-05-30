using Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Configuration
{
    public interface ICommonService
    {

        Task<IReadOnlyCollection<RelationShipMasterDTO>> GetAllRelationsAsync();
    }
}
