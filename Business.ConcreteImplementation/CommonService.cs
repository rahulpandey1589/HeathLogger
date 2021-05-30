using Business.Configuration;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.ConcreteImplementation
{
    public class CommonService : ICommonService
    {
        public Task<IEnumerable<RelationShipMasterDTO>> GetAllRelationsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
