using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Offers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Automapper.OfferDtos;

namespace AukcijeApiMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OfferController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var offers = await _unitOfWork.Offers.GetAll();

            return Ok(_mapper.Map<List<OfferDto>>(offers));
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var offer = await _unitOfWork.Offers.GetById(id);

            return Ok(_mapper.Map<OfferDto>(offer));
        }

        [HttpPost]
        public async Task<IActionResult> AddOffer([FromBody]CreateOfferDto offerDto)
        {
            var offer = _mapper.Map<Offer>(offerDto);
            await _unitOfWork.Offers.Add(offer);

            var success = _unitOfWork.Complete();

            if(success == 1)
            {
                return CreatedAtAction(nameof(Get), new { id = offer.Id }, offer);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}