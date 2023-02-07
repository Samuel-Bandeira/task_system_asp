using TaskSis.Models;

namespace TaskSis.Repositories
{
	public class UserRepository
	{
		public List<User> getUsers() {
			User user1 = new User(1, "Samuel", "email");
			User user2 = new User(2, "Serly", "email");
			List<User> users = new List<User> { user1, user2 };
			return users;
		}
	}
}
