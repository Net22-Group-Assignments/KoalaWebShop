using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using WebAppAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    [Route("api/WebAppMVC")]
    [ApiController]
    public class KoalaCustomerApiController : Controller
    {
        private readonly IRepository<KoalaCustomer> _KoalaDb;
        private readonly IMapper _mapper;
        public KoalaCustomerApiController(IRepository<KoalaCustomer> koalaDb, IMapper mapper)
        {
            _KoalaDb = koalaDb;
            _mapper = mapper;
        }
        //GetAllPersons
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<KoalaCustomer>>> GetAllKoalas()
        {

            IEnumerable<KoalaCustomer> koalaList = await _KoalaDb.GetAllAsync();
            return Ok(koalaList);
        }
        //GetSinglePerson
        [HttpGet("id:int", Name = "GetSingleCustomer")]
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
    }
    
}

