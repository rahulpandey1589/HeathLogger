﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Data.Repositories.Interface.Common;
using Business.Models.Common;
using Business.Configuration.Common;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Business.ConcreteImplementation.Common
{
    public class CommonService : ICommonService
    {
        private readonly IRelationShipRepository _commonRepository;
        private readonly IMapper mapper;
        private readonly ITestMasterRepository _testMasterRepository;

        public CommonService(IRelationShipRepository commonRepository,
            IMapper mapper,
            ITestMasterRepository testMasterRepository)
        {
            this._commonRepository = commonRepository;
            this.mapper = mapper;
            this._testMasterRepository = testMasterRepository;
        }

        public async Task<IReadOnlyCollection<RelationShipMasterDTO>> GetAllRelationsAsync()
        {
            var allRelations = await _commonRepository.Get(x => !x.IsDeleted)
                               .ProjectTo<RelationShipMasterDTO>(mapper.ConfigurationProvider)
                               .ToListAsync()
                               .ConfigureAwait(false);

            return allRelations.AsReadOnly();
        }

        public async Task<IReadOnlyCollection<TestMasterDTO>> GetAllTestAsync()
        {
            try
            {
                var data = await _testMasterRepository.Get(x => !x.IsDeleted)
                                  .ProjectTo<TestMasterDTO>(mapper.ConfigurationProvider)
                                  .ToListAsync()
                                  .ConfigureAwait(false);

                return data.AsReadOnly();

            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
