using System;
using System.Collections.Generic;

namespace ArgumentHelper
{
	/// <summary>
	/// Configuration settings.
	/// </summary>
	public class Configuration : IConfiguration
	{
		private readonly IConfigure configure;

		/// <summary>
		/// Gets or sets the number of spaces before settings in usage.
		/// </summary>
		public int IndentSpaces { get; set; } = 2;

		/// <summary>
		/// Gets or sets the amount of spaces that are in a tab.
		/// </summary>
		public int TabSpaces { get; set; } = 8;

		/// <summary>
		/// Gets or sets the name of the program.
		/// </summary>
		public string ProgramName { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the options.
		/// </summary>
		public List<ConfigOption> Options { get; set; } = new List<ConfigOption>();

		/// <summary>
		/// Gets or sets the commands.
		/// </summary>
		public List<ConfigCommand> Commands { get; set; } = new List<ConfigCommand>();

		/// <summary>
		/// Gets or sets the arguments.
		/// </summary>
		public List<string> Arguments { get; set; } = new List<string>();

		/// <summary>
		/// Initializes a new instance of the <see cref="Configuration"/> class.
		/// </summary>
		public Configuration()
		{
			configure = new Configure(this);
		}

		/// <summary>
		/// Adds an option.
		/// </summary>
		/// <param name="options">The options.</param>
		public IConfigureArgument AddOption(params string[] options)
		{
			var option = new ConfigOption();
			option.Options.AddRange(options);
			var configureOption = new ConfigureOption(configure, option);

			return configureOption;
		}

		/// <summary>
		/// Adds a command.
		/// </summary>
		/// <param name="commands">The commands.</param>
		public IConfigureArgument AddCommand(params string[] commands)
		{
			throw new NotImplementedException();
		}
	}
}
