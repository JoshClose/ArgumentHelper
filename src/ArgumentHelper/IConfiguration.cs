using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IConfiguration
    {
		int IndentSpaces { get; set; }

		int TabSpaces { get; set; }

		string ProgramName { get; set; }

		string Description { get; set; }

		List<IOption> Options { get; }

		List<ICommand> Commands { get; }

		List<string> Arguments { get; }

		IConfigureArgument AddOption(params string[] options);

		IConfigureArgument AddCommand(params string[] commands);
	}
}
