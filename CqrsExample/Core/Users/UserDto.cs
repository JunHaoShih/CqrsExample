namespace CqrsExample.Core.Users
{
	/// <summary>
	/// User DTO
	/// </summary>
	public class UserDto
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

		public static UserDto? Parse(User? user)
		{
			if (user == null)
			{
				return null;
			}

			return new UserDto
			{
				Id = user.Id,
				Username = user.Username,
				Name = user.Name,
			};
		}
	}
}
