using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IOption
    {
		string Description { get; set; }

		bool HasValue { get; set; }

		List<string> Options { get; }
    }
}
