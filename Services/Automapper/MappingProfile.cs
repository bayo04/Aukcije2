using AutoMapper;
using Core.Bids;
using Core.Offers;
using Core.Users;
using Services.Automapper.BidDtos;
using Services.Automapper.OfferDtos;
using Services.Automapper.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Offer, OfferDto>();
            CreateMap<OfferDto, Offer>();

            CreateMap<Offer, CreateOfferDto>();
            CreateMap<CreateOfferDto, Offer>();

            CreateMap<Bid, BidDto>();
            CreateMap<BidDto, Bid>();

            CreateMap<Bid, CreateBidDto>();
            CreateMap<CreateBidDto, Bid>();

            CreateMap<User, RegisterUserDto>();
            CreateMap<RegisterUserDto, User>();
        }
    }
}
