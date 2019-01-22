using System.Collections.Generic;

namespace ArgumentHelper
{
	/// <summary>
	/// Configured arguments.
	/// </summary>
	public interface IArguments
    {
		/// <summary>
		/// Gets the options.
		/// </summary>
		IArgumentCollection Options { get; }

		/// <summary>
		/// Gets the commands.
		/// </summary>
		IArgumentCollection Commands { get; }

		/// <summary>
		/// Gets the arguments.
		/// </summary>
		IReadOnlyList<string> Arguments { get; }
    }
}
