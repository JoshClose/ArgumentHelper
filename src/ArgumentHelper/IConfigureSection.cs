using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IConfigureSection
    {
		IConfigureSection Separator(string separator);

		IConfigureArgument Argument(params string[] args);
    }
}
