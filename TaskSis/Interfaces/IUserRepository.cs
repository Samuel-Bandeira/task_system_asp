using TaskSis.Models;

namespace TaskSis.Interfaces
{
	public interface IUserRepository
	{
		List<User> find();
	}
}
