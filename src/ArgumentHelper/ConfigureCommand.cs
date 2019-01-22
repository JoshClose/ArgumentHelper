using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	/// <summary>
	/// Configures an argument.
	/// </summary>
	public class ConfigureCommand : IConfigureArgument
	{
		private readonly IConfigure configure;
		private readonly ICommand command;

		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigureCommand"/> class.
		/// </summary>
		/// <param name="configure">The configure.</param>
		/// <param name="command">The command.</param>
		public ConfigureCommand(IConfigure configure, ICommand command)
		{
			this.configure = configure;
			this.command = command;
		}

		/// <summary>
		/// Sets the description.
		/// </summary>
		/// <param name="description">The description.</param>
		public IConfigureArgument Description(string description)
		{
			command.Description = description;

			return this;
		}

		/// <summary>
		/// Sets the HasValue flag to true.
		/// </summary>
		public IConfigureArgument HasValue()
		{
			command.HasValue = true;

			return this;
		}

		/// <summary>
		/// Configure settings.
		/// </summary>
		public IConfigure Configure()
		{
			return configure;
		}
	}
}
