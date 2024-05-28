using AutoMapper;
using WebElektronika.az.DTO;
using WebElektronika.az.Models;

namespace WebElektronika.az.Business.Config
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<TechnologyDTO, Technology>();
            CreateMap<Technology, TechnologyDTO>();
        }
    }
}
