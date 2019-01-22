using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class Option : IOption
	{
		public string Description { get; set; }

		public bool HasValue { get; set; }

		public List<string> Options { get; set; } = new List<string>();
	}
}
