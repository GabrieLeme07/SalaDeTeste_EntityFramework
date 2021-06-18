using Microsoft.AspNetCore.Mvc;
using SalaDeTeste_EF.API.Data;
using SalaDeTeste_EF.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaDeTeste_EF.API.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly SalaDeTesteDataContext _context;

        public ProdutoController(SalaDeTesteDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("produto")]
        public IEnumerable<Produto> GetAll()
        {
            return _context.Produtos.ToList();
        }

        [HttpGet]
        [Route("produto/{id}")]
        public Produto GetById(Guid id)
        {
            return _context.Produtos.FirstOrDefault(e => e.Id == id);
        }

        [HttpPost]
        [Route("produto")]
        public IActionResult Add()
        {
            var produto = new Produto
            {
                Nome = "Porta",
                Preco = 100,
                Ativo = true
            };

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return Ok();

        }
    }
}
