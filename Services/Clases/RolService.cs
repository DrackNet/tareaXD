using Mi_Primera_Api_2.Business.Contacts;
using Mi_Primera_Api_2.Models;
using Mi_Primera_Api_2.Services.Contracts;

namespace Mi_Primera_Api_2.Services.Clases
{
    public class RolService : IRolService

    {
        private readonly IRolRepository _IRolRepository;
        public RolService(IRolRepository temp)
        {
            _IRolRepository = temp;
        }
        public Task<List<Rol>> GetList()
        {
            return _IRolRepository.GetList();
        }
    }
}
