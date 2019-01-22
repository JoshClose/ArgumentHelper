using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class Configuration : IConfiguration
	{
		private readonly IConfigure configure;

		public int IndentSpaces { get; set; } = 2;

		public int TabSpaces { get; set; } = 8;

		public string ProgramName { get; set; }

		public string Description { get; set; }

		public List<IOption> Options { get; set; } = new List<IOption>();

		public List<ICommand> Commands { get; set; } = new List<ICommand>();

		public List<string> Arguments { get; set; } = new List<string>();

		public Configuration()
		{
			configure = new Configure(this);
		}

		public IConfigureArgument AddOption(params string[] options)
		{
			var option = new Option();
			option.Options.AddRange(options);
			var configureOption = new ConfigureOption(configure, option);

			return configureOption;
		}

		public IConfigureArgument AddCommand(params string[] commands)
		{
			throw new NotImplementedException();
		}
	}
}
