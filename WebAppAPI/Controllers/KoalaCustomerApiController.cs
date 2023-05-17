using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAppAPI.Repository.IRepository;
using WebAppMVC.Models;

namespace WebAppAPI.Controllers
{
    [Route("api/WebAppAPI/KoalaCustomer")]
    [ApiController]
    public class KoalaCustomerApiController : Controller
    {
        private readonly IRepository<KoalaCustomerApi> _koalaDb;
        private readonly IMapper _mapper;
        public KoalaCustomerApiController(IRepository<KoalaCustomerApi> koalaDb, IMapper mapper)
        {
            _koalaDb = koalaDb;
            _mapper = mapper;
        }
        //GetAllPersons
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<KoalaCustomerApi>>> GetAllKoala()
        {
            IEnumerable<KoalaCustomerApi> koalaList = await _koalaDb.GetAllAsync();
            
            return Ok(koalaList);

        }

        //GetsinglePerson
        [HttpGet("id:int", Name = "GetSinglePerson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetSinglePerson(int koalaId)
        {
            if (koalaId == 0)
            {
                return BadRequest();
            }
            var findCustomer = await _koalaDb.GetAsync(p => p.Id == koalaId);
            if (findCustomer == null)
            {
                return NotFound();
            }
            return Ok(findCustomer);
        }
    }
}
