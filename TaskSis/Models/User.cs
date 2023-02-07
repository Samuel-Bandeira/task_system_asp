namespace TaskSis.Models
{
	public class User
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string Email { get; set; }
		public User(int _Id, string _Name, string _Email)
		{
			Id = _Id;
			Name = _Name;
			Email = _Email;
		}
		
	}
}
