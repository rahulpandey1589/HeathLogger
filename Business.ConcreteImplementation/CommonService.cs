using Business.Configuration;
using Business.Models;
using Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;

namespace Business.ConcreteImplementation
{
    public class CommonService : ICommonService
    {
        private readonly IRelationShipRepository _relationShipRepository;
        private readonly IMapper mapper;

        public CommonService(IRelationShipRepository relationShipRepository, IMapper mapper)
        {
            this._relationShipRepository = relationShipRepository;
            this.mapper = mapper;
        }

        public async Task<IReadOnlyCollection<RelationShipMasterDTO>> GetAllRelationsAsync()
        {
            try
            {
                var allRelations = _relationShipRepository.Get(x => x.IsActive).ToList();

                return mapper
                    .Map<IEnumerable<RelationShipMasterDTO>>(allRelations)
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
