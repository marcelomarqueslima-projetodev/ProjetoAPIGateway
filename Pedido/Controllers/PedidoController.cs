using Microsoft.AspNetCore.Mvc;
using Pedido.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pedido.Controllers
{
    [Route("api/pedido")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly List<ProdutoDTO> produto = new List<ProdutoDTO>()
        {
            new ProdutoDTO()
            {
                ProdutoId = 1,
                Name = "Produto 1"
            },
            new ProdutoDTO()
            {
                ProdutoId = 2,
                Name = "Produto 2"
            },
            new ProdutoDTO()
            {
                ProdutoId = 3,
                Name = "Produto 3"
            }
        };
        [HttpGet]
        public List<ProdutoDTO> All()
        {
            return produto;
        }
        [HttpGet("getbyid/{id}")]
        public ProdutoDTO GetById(int id)
        {
            return produto.FirstOrDefault(u => u.ProdutoId == id);
        }
    }
}
