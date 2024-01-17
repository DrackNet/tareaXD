using Mi_Primera_Api_2.Models;

namespace Mi_Primera_Api_2.Services.Contracts
{
    public interface IRolService 
    {
        Task<List<Rol>> GetList();
    }
}
