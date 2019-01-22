using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IConfigureArgument
	{
		IConfigureArgument Description(string description);

		IConfigureArgument HasValue();

		IConfigure Configure();
	}
}
