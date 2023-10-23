using CqrsExample.Common.Commands;

namespace CqrsExample.Core.Users.Create
{
	public class CreateCommand : ICommand<CreateParams, UserDto>
	{
		private readonly InMemoryUsersContext _context;

		public CreateCommand(InMemoryUsersContext context)
		{
			_context = context;
		}

		public UserDto Execute(CreateParams param)
		{
			User newUser = new()
			{
				Id = _context.Users.Max(user => user.Id) + 1,
				Username = param.Username,
				Name = param.Name,
			};
			_context.Users.Add(newUser);
			return UserDto.Parse(newUser)!;
		}

		public Task<UserDto> ExecuteAsync(CreateParams param)
		{
			throw new NotImplementedException();
		}
	}
}
