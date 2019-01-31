using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class Argument : IArgument
	{
		internal List<string> values = new List<string>();

		public ConfigurationArgument ConfigurationArgument { get; set; }

		public bool Exists { get; set; }

		public string Value { get; set; }

		public IReadOnlyList<string> Values => values;
	}
}
