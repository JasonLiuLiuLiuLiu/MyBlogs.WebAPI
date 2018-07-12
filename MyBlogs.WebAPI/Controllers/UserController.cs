using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlogs.DTO;
using MyBlogs.Service;

namespace MyBlogs.WebAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("user/getall")]
        public List<UserResponse> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet("{id}")]
        [Route("user/getbyid/{id}")]
        public UserResponse GetById([FromRoute]int id)
        {
            return _userService.FindById(id);
        }
    }
}