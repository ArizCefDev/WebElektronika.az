namespace WebElektronika.az.Business.Abstract
{
    public interface IBaseService<RsDTO, T, RqDTO>
    {
        List<RsDTO> GetAll();
        RsDTO Insert(RqDTO dto);
        void Update(RqDTO dto);
        void Delete(int id);
    }
}
