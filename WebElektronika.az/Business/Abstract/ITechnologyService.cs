namespace WebElektronika.az.Business.Abstract
{
                                     //cvb get    cvb gon
    public interface ITechnologyService<RsDTO, T, RqDTO>
    {

        List<RsDTO> GetAll();
        void Insert(RqDTO dto);
        void Update(RqDTO dto);
        void Delete(int id);
    }
}
