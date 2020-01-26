using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IM.Core.Domains;
using IM.DataAccessLayer.Abstract;
using IM.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
    }
}