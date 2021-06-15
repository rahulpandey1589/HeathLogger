using AutoMapper;
using Business.Models.Common;
using Data.Models.Common;

namespace Business.ConcreteImplementation.Mappers
{
    public class MedicalTestMasterMapper : Profile
    {
        public MedicalTestMasterMapper()
        {
            CreateMap<MedicalTestMaster, TestMasterDTO>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
             .ForMember(dest => dest.TestName, opt => opt.MapFrom(x => x.TestName));
        }
    }
}
