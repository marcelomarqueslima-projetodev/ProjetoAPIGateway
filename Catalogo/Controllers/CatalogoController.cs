using Catalogo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Catalogo.Controllers
{
    [Route("api/catalogo")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        private readonly List<CatalogoDTO> catalogo = new List<CatalogoDTO>()
        {
            new CatalogoDTO()
            {
                CatalogoId = 1,
                Name = "Catalogo 1"
            },
            new CatalogoDTO()
            {
                CatalogoId = 2,
                Name = "Catalogo 2"
            },
            new CatalogoDTO()
            {
                CatalogoId = 3,
                Name = "Catalogo 3"
            }
        };
        [HttpGet]
        public List<CatalogoDTO> All()
        {
            return catalogo;
        }
        [HttpGet("getbyid/{id}")]
        public CatalogoDTO GetById(int id)
        {
            return catalogo.FirstOrDefault(u => u.CatalogoId == id);
        }
    }
}
