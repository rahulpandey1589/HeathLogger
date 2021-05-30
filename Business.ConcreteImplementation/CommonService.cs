using Business.Configuration;
using Business.Models;
using Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            var allRelations = _relationShipRepository.List(x => x.IsActive);

            throw new NotImplementedException();
        }
    }
}
