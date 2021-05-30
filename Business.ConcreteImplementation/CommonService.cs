using Business.Configuration;
using Business.Models;
using Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Business.ConcreteImplementation
{
    public class CommonService : ICommonService
    {
        private readonly IRelationShipRepository _relationShipRepository;

        public CommonService(IRelationShipRepository relationShipRepository)
        {
            this._relationShipRepository = relationShipRepository;
        }

        public Task<IReadOnlyCollection<RelationShipMasterDTO>> GetAllRelationsAsync()
        {
            var allRelations = _relationShipRepository.Get(x => x.IsActive).ToList();

            throw new NotImplementedException();
        }
    }
}
