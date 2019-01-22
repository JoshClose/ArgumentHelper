using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class Arguments : IArguments
	{
		private Dictionary<string, string> options = new Dictionary<string, string>();
		private Dictionary<string, string> commands = new Dictionary<string, string>();

		public IReadOnlyDictionary<string, string> Options => options;

		public IReadOnlyDictionary<string, string> Commands => commands;

		IReadOnlyList<string> IArguments.Arguments { get; }

		public void AddOption(string option, string value)
		{
			options.Add(option, value);
		}
	}
}
