using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		IReadOnlyDictionary<string, string> Options { get; }

		/// <summary>
		/// Gets the commands.
		/// </summary>
		IReadOnlyDictionary<string, string> Commands { get; }

		/// <summary>
		/// Gets the arguments.
		/// </summary>
		IReadOnlyList<string> Arguments { get; }
    }
}
