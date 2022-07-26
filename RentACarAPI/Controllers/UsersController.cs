using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Absract;
using RentACar.Entities.Concrete;

namespace RentACarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private  IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            return result.Success ? Ok(result.Data) : BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            return result.Success ? Ok(result.Message) : BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            return result.Success ? Ok(result.Message) : BadRequest();
        }

        [HttpPatch("Update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            return result.Success ? Ok(result.Message) : BadRequest();
        }
    }
}
