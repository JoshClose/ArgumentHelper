using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentHelper
{
	/// <summary>
	/// Parses command line arguments.
	/// </summary>
	public class ArgumentHelper
    {
		private readonly Configuration configuration;

		/// <summary>
		/// Gets the configuration.
		/// </summary>
		public IConfiguration Configuration => configuration;

		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentHelper"/> class.
		/// </summary>
		public ArgumentHelper()
		{
			configuration = new Configuration();
		}

		/// <summary>
		/// Configure settings.
		/// </summary>
		public IConfigure Configure()
		{
			return new Configure(configuration);
		}

		/// <summary>
		/// Gets the usage information.
		/// </summary>
		//public string GetUsage()
		//{
		//	var usage = new StringBuilder();

		//	if (!string.IsNullOrWhiteSpace(Configuration.ProgramName) || Configuration.Options.Any() || Configuration.Commands.Any() || Configuration.Arguments.Any())
		//	{
		//		usage.Append("Usage:");
		//		if (!string.IsNullOrWhiteSpace(Configuration.ProgramName))
		//		{
		//			usage.Append($" {Configuration.ProgramName}");
		//		}

		//		if (Configuration.Options.Any())
		//		{
		//			usage.Append(" [options]");
		//		}

		//		if (Configuration.Commands.Any())
		//		{
		//			usage.Append(" [commands]");
		//		}

		//		foreach (var arg in Configuration.Arguments)
		//		{
		//			usage.Append($" [{arg}]");
		//		}

		//		usage.AppendLine();
		//	}

		//	if (!string.IsNullOrWhiteSpace(Configuration.Description))
		//	{
		//		usage.AppendLine();
		//		usage.AppendLine(Configuration.Description);
		//	}

		//	var prefixSpacesText = string.Format("{0," + Configuration.IndentSpaces + "}", string.Empty);

		//	if (Configuration.Options.Any())
		//	{
		//		usage.AppendLine();

		//		var maxLength = Configuration.Options.Select(o => Configuration.IndentSpaces + o.Options.Select(opt => opt.Length).Sum() + o.Options.Count - 1).Max();
		//		var numberOfTabs = (int)Math.Ceiling(maxLength / (double)Configuration.TabSpaces);
		//		if (maxLength % Configuration.TabSpaces == 0)
		//		{
		//			numberOfTabs++;
		//		}

		//		usage.AppendLine("options:");

		//		var width = numberOfTabs * Configuration.TabSpaces;
		//		foreach (var o in Configuration.Options)
		//		{
		//			var optionsText = $"{prefixSpacesText}{string.Join("|", o.Options)}";
		//			usage.AppendFormat("{0,-" + width + "}{1}", optionsText, o.Description).AppendLine();
		//		}
		//	}

		//	if (Configuration.Commands.Any())
		//	{
		//		usage.AppendLine();

		//		var maxLength = Configuration.Commands.Select(c => Configuration.IndentSpaces + c.Commands.Select(cmd => cmd.Length).Sum() + c.Commands.Count - 1).Max();
		//		var numberOfTabs = (int)Math.Ceiling(maxLength / (double)Configuration.TabSpaces);
		//		if (maxLength % Configuration.TabSpaces == 0)
		//		{
		//			numberOfTabs++;
		//		}

		//		usage.AppendLine("commands:");

		//		var width = numberOfTabs * Configuration.TabSpaces;
		//		foreach (var c in Configuration.Commands)
		//		{
		//			var commandsText = $"{prefixSpacesText}{string.Join("|", c.Commands)}";
		//			usage.AppendFormat("{0,-" + width + "}{1}", commandsText, c.Description).AppendLine();
		//		}
		//	}

		//	return usage.ToString();
		//}

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
				var configArg =
				(
					from s in configuration.Sections
					from a in s.Arguments
					where a.Arguments.Contains(arg)
					select new { Section = s, Argument = a }
				).SingleOrDefault();
				if (configArg == null)
				{
					continue;
				}

				var section = arguments[configArg.Section.Name];

				foreach (var argument in configArg.Argument.Arguments)
				{
					((Argument)arguments[configArg.Section.Name][argument]).ConfigurationArgument = (ConfigurationArgument)configArg.Argument;
				}

				//var argument = (Argument)arguments[configArg.Section.Name][arg];
			}

			return arguments;
		}
	}
}
