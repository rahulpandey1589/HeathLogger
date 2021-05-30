using AutoMapper;
using Business.Models;
using Data.Models.Common;

namespace Business.ConcreteImplementation.Mappers
{
    public class RelationShipMasterMapper : Profile
    {
        public RelationShipMasterMapper()
        {
            CreateMap<RelationShipMaster, RelationShipMasterDTO>()
                ;
        }
    }
}
