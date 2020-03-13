using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Automapper.UserDtos
{
    public class RegisterUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
