using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class ConfigurationArgument : IConfigurationArgument
	{
		public string Description { get; set; }

		public bool HasValues { get; set; }

		public string ValueName { get; set; }

		public int ValueCount { get; set; }

		public List<string> Arguments { get; } = new List<string>();
	}
}
