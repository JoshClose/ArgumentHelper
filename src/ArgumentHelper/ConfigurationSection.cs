using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class ConfigurationSection : IConfigurationSection
	{
		public string Name { get; set; }

		public string Separator { get; set; }

		public List<IConfigurationArgument> Arguments { get; } = new List<IConfigurationArgument>();
	}
}
