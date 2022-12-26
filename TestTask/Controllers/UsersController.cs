using Microsoft.AspNetCore.Mvc;
using Models;
using System.Threading.Tasks;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _userService.Get(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
