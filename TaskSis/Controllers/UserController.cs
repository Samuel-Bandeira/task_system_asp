using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TaskSis.Models;
using TaskSis.Repositories;

namespace TaskSis.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly UserRepository _userRepo;
		public UserController(UserRepository repoCtx)
		{
			_userRepo = repoCtx;
		}
		[HttpGet]
		public ActionResult<List<User>> findUsers(HttpRequestMessage request)
		{
			return _userRepo.getUsers();
		}
	}
}
