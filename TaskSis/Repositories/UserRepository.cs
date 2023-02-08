using TaskSis.Interfaces;
using TaskSis.Models;

namespace TaskSis.Repositories
{
	public class UserRepository : IUserRepository
	{
		public List<User> find()
		{
			User user1 = new User(1, "Samuel", "email");
			User user2 = new User(2, "Serly", "email");
			User user3 = new User(3, "John", "email");
			List<User> users = new List<User> { user1, user2, user3 };
			return users;
		}
	}
}
