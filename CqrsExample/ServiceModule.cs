using Autofac;
using CqrsExample.Common.Commands;
using CqrsExample.Core.Users;

namespace CqrsExample
{
	public class ServiceModule : Module
    {
		private readonly ConfigurationManager _configurationManager;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="configurationManager"></param>
		public ServiceModule(ConfigurationManager configurationManager)
		{
			_configurationManager = configurationManager;
		}

		/// <summary>
		/// Register here
		/// </summary>
		/// <param name="builder"></param>
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<InMemoryUsersContext>().SingleInstance();

			builder.RegisterType <Core.Users.GetAll.GetAllCommand>().As<ICommand<Core.Users.GetAll.GetAllParams, IEnumerable<UserDto>>>();
			builder.RegisterType<Core.Users.GetById.GetByIdCommand>().As<ICommand<Core.Users.GetById.GetByIdParams, UserDto?>>();
			builder.RegisterType<Core.Users.Create.CreateCommand>().As<ICommand<Core.Users.Create.CreateParams, UserDto>>();
		}
	}
}
