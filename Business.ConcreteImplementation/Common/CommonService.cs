using System.Collections.Generic;
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
        private readonly IMapper _mapper;
        private readonly ITestMasterRepository _testMasterRepository;

        public CommonService(
            IRelationShipRepository commonRepository,
            IMapper mapper,
            ITestMasterRepository testMasterRepository)
        {
            this._commonRepository = commonRepository;
            this._mapper = mapper;
            this._testMasterRepository = testMasterRepository;
        }

        public async Task<IReadOnlyCollection<RelationShipMasterDTO>> GetAllRelationsAsync()
        {
            var allRelations = await _commonRepository.Get(x => !x.IsDeleted)
                               .ProjectTo<RelationShipMasterDTO>(_mapper.ConfigurationProvider)
                               .ToListAsync();

            return allRelations.AsReadOnly();
        }

        public async Task<IReadOnlyCollection<TestMasterDTO>> GetAllTestAsync(int? id)
        {

            var data = await _testMasterRepository.Get(x => !x.IsDeleted && x.Id == id.Value)
                            .ProjectTo<TestMasterDTO>(_mapper.ConfigurationProvider)
                            .ToListAsync();

            return data.AsReadOnly();
        }
    }
}
