using AutoMapper;
using Business.Models;
using Data.Models.Common;
using System.Collections.Generic;

namespace HealthLoggerAPI.Mappers
{
    public class RelationShipMasterMapper : Profile
    {
        public RelationShipMasterMapper()
        {
            CreateMap<RelationShipMaster, RelationShipMasterDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.RelationShipId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.RelationShipName));

        }
    }
}
