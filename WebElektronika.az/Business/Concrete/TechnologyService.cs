using AutoMapper;
using WebElektronika.az.Business.Abstract;
using WebElektronika.az.DTO;
using WebElektronika.az.Models;
using WebElektronika.az.Models.Context;

namespace WebElektronika.az.Business.Concrete
{
    public class TechnologyService
        : BaseService<TechnologyDTO, Technology, TechnologyDTO>, ITechnologyService
    {
        public TechnologyService(IMapper mapper, AppDBContext dBContext) : base(mapper, dBContext)
        {
        }
    }
}
