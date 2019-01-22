using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class Command : ICommand
	{
		public string Description { get; set; }

		public bool HasValue { get; set; }

		public List<string> Commands { get; } = new List<string>();
	}
}
