using Mi_Primera_Api_2.Models;
using Mi_Primera_Api_2.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mi_Primera_Api_2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
        
        public class RolController
        {
            private readonly IRolService _IRolService;
            public RolController(IRolService temp)
            {
                this._IRolService = temp;
            }
            [HttpGet]
            public async Task<List<Rol>> GetList()
            {
                return await _IRolService.GetList();
            }
        }
    
}