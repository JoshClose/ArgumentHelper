using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	/// <summary>
	/// Configures configuration settings.
	/// </summary>
	public interface IConfigure
    {
		/// <summary>
		/// Sets the program name.
		/// </summary>
		/// <param name="programName">The program name.</param>
		IConfigure ProgramName(string programName);

		/// <summary>
		/// Sets the description.
		/// </summary>
		/// <param name="description">The description.</param>
		IConfigure Description(string description);

		/// <summary>
		/// Sets the options.
		/// </summary>
		/// <param name="options">The options.</param>
		IConfigureArgument Option(params string[] options);

		/// <summary>
		/// Sets the commands.
		/// </summary>
		/// <param name="commands">The commands.</param>
		IConfigureArgument Command(params string[] commands);

		/// <summary>
		/// Sets the argument.
		/// </summary>
		/// <param name="argument">The argument.</param>
		IConfigureArgument Argument(string argument);
	}
}
