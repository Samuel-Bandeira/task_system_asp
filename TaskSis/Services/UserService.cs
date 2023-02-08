using TaskSis.Interfaces;
using TaskSis.Models;

namespace TaskSis.Services
{
	public class UserService : IUserService
	{
		IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		public List<User> getAll()
		{
			List<User> users = _userRepository.find();
			return users;
		}
	}
}
