using System.Collections.Generic;

namespace ArgumentHelper
{
	/// <summary>
	/// Configured arguments.
	/// </summary>
	public class ArgumentsResult : IArguments
	{
		private readonly ArgumentCollection options = new ArgumentCollection();
		private readonly ArgumentCollection commands = new ArgumentCollection();
		private readonly List<string> arguments = new List<string>();

		/// <summary>
		/// Gets the options.
		/// </summary>
		public IArgumentCollection Options => options;

		/// <summary>
		/// Gets the commands.
		/// </summary>
		public IArgumentCollection Commands => commands;

		/// <summary>
		/// Gets the arguments.
		/// </summary>
		public IReadOnlyList<string> Arguments => arguments;

		internal void AddOption(ConfigOption option, string value)
		{
			var argument = new Argument
			{
				Value = value
			};
			argument.Arguments.AddRange(option.Options);

			options.Arguments.Add(argument);
		}

		internal void AddCommand(ConfigCommand command, string value)
		{
			var argument = new Argument
			{
				Value = value
			};
			argument.Arguments.AddRange(command.Commands);

			commands.Arguments.Add(argument);
		}

		internal void AddArgument(string argument)
		{
			arguments.Add(argument);
		}
	}
}
