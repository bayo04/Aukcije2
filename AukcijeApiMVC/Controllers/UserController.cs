using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Automapper.UserDtos;

namespace AukcijeApiMVC.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDto userDto)
        {
            var newUser = new IdentityUser { UserName = userDto.Username, Email = userDto.Email };

            var result = await _userManager.CreateAsync(_mapper.Map<User>(userDto), userDto.Password);

            if (result.Succeeded)
            {
                return Ok(); // Returnat created et
            }
            else
            {
                return BadRequest();
            }

        }
    }
}