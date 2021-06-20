using AutoMapper;
using Business.Models.Mapper;
using Data.Models.Common;

namespace Business.Models.Common
{
    public class TestMasterDTO : IMapFrom<MedicalTestMaster>
    {
        public int Id { get; set; }

        public string TestName { get; set; }

        public bool IsDeleted { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MedicalTestMaster, TestMasterDTO>().ReverseMap();
        }
    }
}
