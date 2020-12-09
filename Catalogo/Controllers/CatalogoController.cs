using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        // GET: api/<CatalogoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Produto 1", "Produto 2" };
        }
    }
}
