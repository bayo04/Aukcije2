using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Bids;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Automapper.BidDtos;

namespace AukcijeApiMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BidController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bids = await _unitOfWork.Offers.GetAll();

            return Ok(_mapper.Map<List<BidDto>>(bids));
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var bid = await _unitOfWork.Offers.GetById(id);

            return Ok(_mapper.Map<BidDto>(bid));
        }

        [HttpPost]
        public async Task<IActionResult> AddOffer([FromBody]CreateBidDto bidDto)
        {
            var bid = _mapper.Map<Bid>(bidDto);
            await _unitOfWork.Bids.Add(bid);

            var success = _unitOfWork.Complete();

            if (success == 1)
            {
                return CreatedAtAction(nameof(Get), new { id = bid.Id }, bid);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}