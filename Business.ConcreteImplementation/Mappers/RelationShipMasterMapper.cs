using AutoMapper;
using Business.Models.Common;
using Data.Models.Common;

namespace Business.ConcreteImplementation.Mappers
{
    public class RelationShipMasterMapper : Profile
    {
        public RelationShipMasterMapper()
        {
            CreateMap<RelationShipMaster, RelationShipMasterDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.RelationShipName));
        }
    }
}
