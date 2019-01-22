using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class ConfigureCommand : IConfigureArgument
	{
		private readonly IConfigure configure;
		private readonly ICommand command;

		public ConfigureCommand(IConfigure configure, ICommand command)
		{
			this.configure = configure;
			this.command = command;
		}

		public IConfigureArgument Description(string description)
		{
			command.Description = description;

			return this;
		}

		public IConfigureArgument HasValue()
		{
			command.HasValue = true;

			return this;
		}

		public IConfigure Configure()
		{
			return configure;
		}
	}
}
