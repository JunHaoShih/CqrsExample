namespace CqrsExample.Core.Users.Create
{
	/// <summary>
	/// Parameters to create user
	/// </summary>
	public class CreateParams
	{
		/// <summary>
		/// Username
		/// </summary>
		public string Username { get; set; } = null!;

		/// <summary>
		/// Diaplay name of user
		/// </summary>
		public string Name { get; set; } = null!;
	}
}
