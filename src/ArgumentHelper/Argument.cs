using System.Collections.Generic;

namespace ArgumentHelper
{
	public class Argument
    {
        public string Value { get; set; }

		public List<string> Arguments { get; } = new List<string>();
	}
}
