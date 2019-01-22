using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IArguments
    {
		IReadOnlyDictionary<string, string> Options { get; }

		IReadOnlyDictionary<string, string> Commands { get; }

		IReadOnlyList<string> Arguments { get; }
    }
}
