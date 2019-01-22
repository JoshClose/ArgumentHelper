using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IConfigure
    {
		IConfigure ProgramName(string programName);

		IConfigure Description(string description);

		IConfigureArgument Option(params string[] options);

		IConfigureArgument Command(params string[] commands);

		IConfigureArgument Argument(string argument);
	}
}
