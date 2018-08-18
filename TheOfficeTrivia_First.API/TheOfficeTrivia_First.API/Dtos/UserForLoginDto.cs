using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheOfficeTrivia_First.API.Dtos
{
    public class UserForLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
