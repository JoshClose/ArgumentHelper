using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	/// <summary>
	/// Configuration settings.
	/// </summary>
	public interface IConfiguration
    {
		/// <summary>
		/// Gets or sets the number of spaces before settings in usage.
		/// </summary>
		int IndentSpaces { get; set; }

		/// <summary>
		/// Gets or sets the amount of spaces that are in a tab.
		/// </summary>
		int TabSpaces { get; set; }

		/// <summary>
		/// Gets or sets the name of the program.
		/// </summary>
		string ProgramName { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		string Description { get; set; }

		/// <summary>
		/// Gets or sets the options.
		/// </summary>
		List<IOption> Options { get; }

		/// <summary>
		/// Gets or sets the commands.
		/// </summary>
		List<ICommand> Commands { get; }

		/// <summary>
		/// Gets or sets the arguments.
		/// </summary>
		List<string> Arguments { get; }

		/// <summary>
		/// Adds an option.
		/// </summary>
		/// <param name="options">The options.</param>
		IConfigureArgument AddOption(params string[] options);

		/// <summary>
		/// Adds a command.
		/// </summary>
		/// <param name="commands">The commands.</param>
		IConfigureArgument AddCommand(params string[] commands);
	}
}
