namespace CqrsExample.Core.Users
{
	public class InMemoryUsersContext
	{
		public IList<User> Users { get; set; }

		public InMemoryUsersContext()
		{
			Users = new List<User>()
			{
				new User() { Id = 1, Name = "Tom", Username = "User1" },
				new User() { Id = 2, Name = "Adam", Username = "User2" },
				new User() { Id = 3, Name = "Steve", Username = "User3" },
			};
		}
	}
}
