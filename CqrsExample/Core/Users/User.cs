namespace CqrsExample.Core.Users
{
	/// <summary>
	/// User entity
	/// </summary>
	public class User
	{
		/// <summary>
		/// User id
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Username
		/// </summary>
		public string Username { get; set; } = null!;

		/// <summary>
		/// Display name of user
		/// </summary>
		public string Name { get; set; } = null!;
	}
}
