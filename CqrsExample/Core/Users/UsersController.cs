using CqrsExample.Common.Commands;
using CqrsExample.Core.Users.Create;
using CqrsExample.Core.Users.GetAll;
using CqrsExample.Core.Users.GetById;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CqrsExample.Core.Users
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		/// <summary>
		/// Get all users
		/// </summary>
		/// <param name="cmd">Get all cmd</param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult Get([FromServices] ICommand<GetAllParams, IEnumerable<UserDto>> cmd)
		{
			return Ok(cmd.Execute(new GetAllParams()));
		}

		/// <summary>
		/// Get user by id
		/// </summary>
		/// <param name="id">User id</param>
		/// <param name="cmd">Get by id cmd</param>
		/// <returns></returns>
		[HttpGet("{id}")]
		public IActionResult Get(int id, [FromServices] ICommand<GetByIdParams, UserDto?> cmd)
		{
			return Ok(cmd.Execute(new GetByIdParams { Id = id }));
		}

		/// <summary>
		/// Create a user
		/// </summary>
		/// <param name="createParams">Create user parameters</param>
		/// <param name="cmd"></param>
		/// <returns></returns>
		[HttpPost]
		public IActionResult Post([FromBody] CreateParams createParams, [FromServices] ICommand<CreateParams, UserDto> cmd)
		{
			return Ok(cmd.Execute(createParams));
		}
	}
}
