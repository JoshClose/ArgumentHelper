using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IArgument
    {
		bool Exists { get; }

		string Value { get; }

		IReadOnlyList<string> Values { get; }
    }
}
