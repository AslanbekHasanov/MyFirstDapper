using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDapper.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserControler:ControllerBase
    {

        public UserControler(IUserService userService)
        {
            this.userService = userService;
        }

        private readonly IUserService userService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await userService.GetAll());
        }

        [HttpGet]
        public async Task<IActionResult> Get(int Id)
        {
            return Ok(await userService.Get(Id));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]PersonModel model)
        {
            return Ok(await userService.Create(model));
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]int Id, PersonModel model)
        {
            return Ok(await userService.Update(Id, model));
        }
    }
}
