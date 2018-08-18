using System.Threading.Tasks;
using TheOfficeTrivia_First.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
//using AutoMapper;
using TheOfficeTrivia_First.API.Dtos;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    //[ApiController]
    public class UsersController : ControllerBase
    {
        // private readonly IOfficeRepository _repo;
        // private readonly IMapper _mapper;

        // public UsersController(IOfficeRepository repo, IMapper mapper) {
        //     _mapper = mapper;
        //     _repo = repo;
        // }

        // [HttpGet]
        // public async Task<IActionResult> GetUsers() 
        // {
        //     var users = await _repo.GetUsers();

        //     var usersToReturn = _mapper.Map<IEnumerable<UserForListDto>>(users);

        //     return Ok(usersToReturn);
        // }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> GetUser(int id) 
        // {
        //     var user = await _repo.GetUser(id);
        //     var userToReturn = _mapper.Map<UserForDetailedDto>(user);

        //     return Ok(userToReturn);
        // }
    }
}