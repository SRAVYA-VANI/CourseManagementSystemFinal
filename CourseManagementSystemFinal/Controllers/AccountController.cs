using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CourseManagementSystemFinal.Models;
using Microsoft.EntityFrameworkCore;
using CourseManagementSystemFinal.Repositories;

namespace CourseManagementSystemFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

   

    // GET: api/Products
   
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository repository;
        public AccountController(IAccountRepository repo)
        {
            repository = repo;
        }



        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(SignUpModel signupModel)
        {
            var result = await repository.SignUpAsync(signupModel);
            if (result.Succeeded)
            {
                return Ok(result);

            }
            return Unauthorized();
        }
        [HttpPost("Login")]
        public async Task<IActionResult> SignIn([FromBody] Login login)
        {
            var result = await repository.LoginAsync(login);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }
    }
}
