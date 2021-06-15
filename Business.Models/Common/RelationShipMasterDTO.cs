using AutoMapper;
using Business.Models.Mapper;
using Data.Models.Common;

namespace Business.Models.Common
{
    public class RelationShipMasterDTO : IMapFrom<RelationShipMaster>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RelationShipMaster, RelationShipMasterDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.RelationShipName));
        }
    }
}
