using Mi_Primera_Api_2.Models;

namespace Mi_Primera_Api_2.Business.Contacts
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
    }
}
