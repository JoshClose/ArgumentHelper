using System.Collections.Generic;
using System.Linq;

namespace ArgumentHelper
{
	public class ArgumentCollection : IArgumentCollection
    {
		internal readonly List<Argument> Arguments = new List<Argument>();

		public string this[string arg] => Arguments.SingleOrDefault(a => a.Arguments.Contains(arg))?.Value;

		public bool Contains(string arg) => Arguments.Any(a => a.Arguments.Contains(arg));
    }
}
