using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class Arguments : IArguments
	{
		private readonly Dictionary<string, Section> sections = new Dictionary<string, Section>();

		public ISection this[string section]
		{
			get
			{
				if (!sections.ContainsKey(section))
				{
					sections.Add(section, new Section());
				}

				return sections[section];
			}
		}
	}
}
