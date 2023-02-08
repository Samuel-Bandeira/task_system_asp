using Microsoft.AspNetCore.Mvc;
using TaskSis.Interfaces;
using TaskSis.Models;

namespace TaskSis.Controllers
{
	[Route("/user")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		private readonly ILogger<UserController> _logger;
		public UserController(IUserService userService, ILogger<UserController> logger)
		{
			_userService = userService;
			_logger = logger;
		}
		[HttpGet("all")]
		public List<User> findUsers()
		{
			List<User> users = _userService.getAll();
			return users;
		}
	}
}
