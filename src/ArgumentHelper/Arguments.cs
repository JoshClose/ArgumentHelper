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
	public class Arguments : IArguments
	{
		private readonly Dictionary<string, string> options = new Dictionary<string, string>();
		private readonly Dictionary<string, string> commands = new Dictionary<string, string>();

		/// <summary>
		/// Gets the options.
		/// </summary>
		public IReadOnlyDictionary<string, string> Options => options;

		/// <summary>
		/// Gets the commands.
		/// </summary>
		public IReadOnlyDictionary<string, string> Commands => commands;

		/// <summary>
		/// Gets the arguments.
		/// </summary>
		IReadOnlyList<string> IArguments.Arguments { get; }

		/// <summary>
		/// Adds an option.
		/// </summary>
		/// <param name="option">The option.</param>
		/// <param name="value">The value.</param>
		public void AddOption(string option, string value)
		{
			options.Add(option, value);
		}

		/// <summary>
		/// Adds a command.
		/// </summary>
		/// <param name="command">The command.</param>
		/// <param name="value">The value.</param>
		public void AddCommand(string command, string value)
		{
			commands.Add(command, value);
		}
	}
}
