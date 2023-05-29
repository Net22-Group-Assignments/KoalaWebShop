using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAppAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using WebAppMVC.Models;
using WebAppMVC.Models.Dto;
using Microsoft.AspNetCore.Authorization;

namespace WebAppMVC.Controllers
{
	[Route("api/WebAppMVC/Product")]
    [ApiController]
    public class ProductApiController : Controller
    {
        private readonly IRepository<Product> _KoalaDb;
        private readonly IMapper _mapper;

        public ProductApiController(IRepository<Product> koalaDb, IMapper mapper)
        {
            _KoalaDb = koalaDb;
            _mapper = mapper;
        }

        //GetAllProducts
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllKoalas()
        {
            IEnumerable<Product> koalaList = await _KoalaDb.GetAllAsync();
            return Ok(koalaList);
        }

        //GetSinglePerson
        [HttpGet("id:int", Name = "GetSingleProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetSinglePerson(int koalaId)
        {
            if (koalaId == 0)
            {
                return BadRequest();
            }
            var findKoala = await _KoalaDb.GetAsync(p => p.Id == koalaId);
            if (findKoala == null)
            {
                return NotFound();
            }
            return Ok(findKoala);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateProduct([FromBody] ProductDto productDto)
        {
            if (productDto == null)
            {
                return BadRequest(productDto);
            }
            Product product = _mapper.Map<Product>(productDto);
            await _KoalaDb.CreateAsync(product);
            return CreatedAtAction("CreateProduct", new { id = product.Id }, product);
        }
    }
}
