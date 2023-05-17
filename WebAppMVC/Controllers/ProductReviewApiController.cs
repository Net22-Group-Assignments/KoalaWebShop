﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using WebAppAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    [Route("api/WebAppMVC/ProductReview")]
    [ApiController]
    public class ProductReviewApiController : Controller
    {

        private readonly IRepository<ProductReview> _KoalaDb;
        private readonly IMapper _mapper;
        public ProductReviewApiController(IRepository<ProductReview> koalaDb, IMapper mapper)
        {
            _KoalaDb = koalaDb;
            _mapper = mapper;
        }
        //GetAllPersons
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductReview>>> GetAllKoalas()
        {

            IEnumerable<ProductReview> koalaList = await _KoalaDb.GetAllAsync();
            return Ok(koalaList);
        }
        //GetSinglePerson
        [HttpGet("id:int", Name = "GetProductReview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetSinglePerson(int koalaId)
        {
            if (koalaId == 0)
            {
                return BadRequest();
            }
            var findKoala = await _KoalaDb.GetAsync(p => p.ParentId == koalaId);
            if (findKoala == null)
            {
                return NotFound();
            }
            return Ok(findKoala);
        }

    }
}