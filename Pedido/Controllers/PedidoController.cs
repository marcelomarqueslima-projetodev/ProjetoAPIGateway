using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pedido.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        // GET: api/<PedidoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Item 1", "Item 2" };
        }
    }
}
