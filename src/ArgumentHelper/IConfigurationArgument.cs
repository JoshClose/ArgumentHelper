using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IConfigurationArgument
    {
		string Description { get; set; }

		bool HasValues { get; set; }

		string ValueName { get; set; }

		int ValueCount { get; set; }

		List<string> Arguments { get; }
	}
}
