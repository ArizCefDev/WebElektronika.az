using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebElektronika.az.Business.Abstract;
using WebElektronika.az.Models.Context;

namespace WebElektronika.az.Business.Concrete
{
    public class BaseService<RsDTO, T, RqDTO> : IBaseService<RsDTO, T, RqDTO>
        where T : class
    {
        protected readonly IMapper _mapper;
        protected readonly AppDBContext _dBContext;
        protected readonly DbSet<T> _dBSet;

        public BaseService(IMapper mapper, AppDBContext dBContext)
        {
            _mapper = mapper;
            _dBContext = dBContext;
            _dBSet = dBContext.Set<T>();
        }

        public void Delete(int id)
        {
            var ent = _dBSet.Find(id);//id ni axtar tap
            _dBSet.Remove(ent); //id sil
            _dBContext.SaveChanges(); //yadda saxla
        }

        public List<RsDTO> GetAll()
        {
            var ent = _dBSet.ToList(); //select
            var rsdto = _mapper.Map<List<RsDTO>>(ent);
            return rsdto;
        }

       
        public RsDTO Insert(RqDTO dto)
        {
            var ent = _mapper.Map<T>(dto);

            _dBSet.Add(ent);
            _dBContext.SaveChanges();

            var rsdto = _mapper.Map<RsDTO>(ent);
            return rsdto;
        }

        public void Update(RqDTO dto)
        {
            var ent = _mapper.Map<T>(dto);

            _dBSet.Update(ent);
            _dBContext.SaveChanges();
        }
        
    }
}

