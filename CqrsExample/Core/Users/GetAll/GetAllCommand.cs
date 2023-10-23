using CqrsExample.Common.Commands;

namespace CqrsExample.Core.Users.GetAll
{
	public class GetAllCommand : ICommand<GetAllParams, IEnumerable<UserDto>>
	{
		private readonly InMemoryUsersContext _context;

		public GetAllCommand(InMemoryUsersContext context)
		{
			_context = context;
		}

		public IEnumerable<UserDto> Execute(GetAllParams param)
		{
			return _context.Users.Select(x => UserDto.Parse(x));
		}

		public Task<IEnumerable<UserDto>> ExecuteAsync(GetAllParams param)
		{
			throw new NotImplementedException();
		}
	}
}
