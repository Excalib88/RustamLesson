using Microsoft.AspNetCore.Mvc;

namespace RustamLesson
{
	[Route("user")]
	[ApiController]
	public class UserController : Controller
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}
		//	user/get
		[HttpGet("get")]
		public IActionResult GetUser()
		{
			_userService.Register("");
			return Ok("Вы вошли");
		}

		//	user/get-all
		[HttpGet]
		public IActionResult GetAll(string name)
		{
			return Ok();
		}

		[HttpPost]
		public IActionResult Set([FromBody] User user)
		{
			return Ok();
		}

		[HttpPost("set2")]
		public IActionResult Set2()
		{
			return Ok();
		}
	}
}