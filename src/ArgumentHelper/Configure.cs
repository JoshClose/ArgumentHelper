using System;

namespace ArgumentHelper
{
	/// <summary>
	/// Configures configuration settings.
	/// </summary>
	public class Configure : IConfigure
	{
		private readonly IConfiguration configuration;

		/// <summary>
		/// Initializes a new instance of the <see cref="Configure"/> class.
		/// </summary>
		/// <param name="configuration">The configuration.</param>
		public Configure(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		/// <summary>
		/// Sets the program name.
		/// </summary>
		/// <param name="programName">The program name.</param>
		public IConfigure ProgramName(string programName)
		{
			configuration.ProgramName = programName;

			return this;
		}

		/// <summary>
		/// Sets the description.
		/// </summary>
		/// <param name="description">The description.</param>
		public IConfigure Description(string description)
		{
			configuration.Description = description;

			return this;
		}

		/// <summary>
		/// Sets the options.
		/// </summary>
		/// <param name="options">The options.</param>
		public IConfigureArgument Option(params string[] options)
		{
			if (options == null)
			{
				throw new ArgumentNullException(nameof(options));
			}

			if (options.Length == 0)
			{
				throw new ArgumentException($"Argument '{nameof(options)}' cannot be empty.");
			}

			var option = new ConfigOption();
			option.Options.AddRange(options);
			var configureOption = new ConfigureOption(this, option);

			configuration.Options.Add(option);

			return configureOption;
		}

		/// <summary>
		/// Sets the commands.
		/// </summary>
		/// <param name="command">The commands.</param>
		public IConfigureArgument Command(string command)
		{
			if (command == null)
			{
				throw new ArgumentNullException(nameof(command));
			}

			command = command.Trim();

			if (string.IsNullOrEmpty(command))
			{
				throw new ArgumentException($"Argument '{nameof(command)}' cannot be empty.");
			}

			var configCommand = new ConfigCommand();
			configCommand.Commands.Add(command);
			var configureCommand = new ConfigureCommand(this, configCommand);

			configuration.Commands.Add(configCommand);

			return configureCommand;
		}

		/// <summary>
		/// Sets the argument.
		/// </summary>
		/// <param name="argument">The argument.</param>
		public IConfigureArgument Argument(string argument)
		{
			if (argument == null)
			{
				throw new ArgumentNullException(nameof(argument));
			}

			argument = argument.Trim();

			if (string.IsNullOrWhiteSpace(argument))
			{
				throw new ArgumentException($"Argument '{nameof(argument)}' cannot be empty.");
			}

			configuration.Arguments.Add(argument);

			return new ConfigureArgument(this);
		}
	}
}
