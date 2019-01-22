using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	/// <summary>
	/// Parses command line arguments.
	/// </summary>
	public class ArgumentHelper
    {
		/// <summary>
		/// Gets the configuration.
		/// </summary>
		public IConfiguration Configuration { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentHelper"/> class.
		/// </summary>
		public ArgumentHelper()
		{
			Configuration = new Configuration();
		}

		/// <summary>
		/// Configure settings.
		/// </summary>
		public IConfigure Configure()
		{
			return new Configure(Configuration);
		}

		/// <summary>
		/// Gets the usage information.
		/// </summary>
		public string GetUsage()
		{
			var usage = new StringBuilder();

			if (!string.IsNullOrWhiteSpace(Configuration.ProgramName) || Configuration.Options.Any() || Configuration.Commands.Any() || Configuration.Arguments.Any())
			{
				usage.Append("Usage:");
				if (!string.IsNullOrWhiteSpace(Configuration.ProgramName))
				{
					usage.Append($" {Configuration.ProgramName}");
				}

				if (Configuration.Options.Any())
				{
					usage.Append(" [options]");
				}

				if (Configuration.Commands.Any())
				{
					usage.Append(" [commands]");
				}

				foreach (var arg in Configuration.Arguments)
				{
					usage.Append($" [{arg}]");
				}

				usage.AppendLine();
			}

			if (!string.IsNullOrWhiteSpace(Configuration.Description))
			{
				usage.AppendLine();
				usage.AppendLine(Configuration.Description);
			}

			var prefixSpacesText = string.Format("{0," + Configuration.IndentSpaces + "}", string.Empty);

			if (Configuration.Options.Any())
			{
				usage.AppendLine();

				var maxLength = Configuration.Options.Select(o => Configuration.IndentSpaces + o.Options.Select(opt => opt.Length).Sum() + o.Options.Count - 1).Max();
				var numberOfTabs = (int)Math.Ceiling(maxLength / (double)Configuration.TabSpaces);
				if (maxLength % Configuration.TabSpaces == 0)
				{
					numberOfTabs++;
				}

				usage.AppendLine("options:");

				var width = numberOfTabs * Configuration.TabSpaces;
				foreach (var o in Configuration.Options)
				{
					var optionsText = $"{prefixSpacesText}{string.Join("|", o.Options)}";
					usage.AppendFormat("{0,-" + width + "}{1}", optionsText, o.Description).AppendLine();
				}
			}

			if (Configuration.Commands.Any())
			{
				usage.AppendLine();

				var maxLength = Configuration.Commands.Select(c => Configuration.IndentSpaces + c.Commands.Select(cmd => cmd.Length).Sum() + c.Commands.Count - 1).Max();
				var numberOfTabs = (int)Math.Ceiling(maxLength / (double)Configuration.TabSpaces);
				if (maxLength % Configuration.TabSpaces == 0)
				{
					numberOfTabs++;
				}

				usage.AppendLine("commands:");

				var width = numberOfTabs * Configuration.TabSpaces;
				foreach (var c in Configuration.Commands)
				{
					var commandsText = $"{prefixSpacesText}{string.Join("|", c.Commands)}";
					usage.AppendFormat("{0,-" + width + "}{1}", commandsText, c.Description).AppendLine();
				}
			}

			return usage.ToString();
		}

		/// <summary>
		/// Parses the arguments.
		/// </summary>
		/// <param name="args">The arguments to parse.</param>
		public IArguments Parse(string[] args)
		{
			var arguments = new Arguments();

			var queue = new Queue<string>(args);
			while (queue.TryDequeue(out string arg))
			{
				string value = null;
				var configOption = Configuration.Options.SingleOrDefault(o => o.Options.Contains(arg));
				if (configOption.HasValue)
				{
					if (!queue.TryPeek(out value) || Configuration.Options.Any(o => o.Options.Contains(value)))
					{
						Console.WriteLine($"No value was found for option '{arg}'.");
						return null;
					}

					queue.Dequeue();
				}

				arguments.AddOption(arg, value);
			}

			return arguments;
		}
	}
}
