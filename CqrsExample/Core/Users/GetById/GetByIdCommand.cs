using CqrsExample.Common.Commands;

namespace CqrsExample.Core.Users.GetById
{
	public class GetByIdCommand : ICommand<GetByIdParams, UserDto?>
	{
		private readonly InMemoryUsersContext _context;

		public GetByIdCommand(InMemoryUsersContext context)
		{
			_context = context;
		}

		public UserDto? Execute(GetByIdParams param)
		{
			return UserDto.Parse(_context.Users
				.FirstOrDefault(user => user.Id == param.Id));
		}

		public Task<UserDto?> ExecuteAsync(GetByIdParams param)
		{
			throw new NotImplementedException();
		}
	}
}
