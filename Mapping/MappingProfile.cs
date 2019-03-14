using AutoMapper;
using Viga.Model;
using Viga.Resources;

namespace Viga.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<Viga.Model.Model,ModelResource>();
        }
    }
}