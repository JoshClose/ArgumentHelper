using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class Section : ISection
	{
		private Dictionary<string, Argument> arguments = new Dictionary<string, Argument>();

		public string Name { get; set; }

		public IArgument this[string argument]
		{
			get
			{
				if (!arguments.ContainsKey(argument))
				{
					arguments.Add(argument, new Argument());
				}

				return arguments[argument];
			}
		}
	}
}
