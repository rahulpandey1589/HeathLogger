using AutoMapper;

namespace Business.Models.Mapper
{
    public interface IMapFrom<T>
    { 
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }

    public class BaseMapper
    {

    }
}
