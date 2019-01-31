using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface IConfigurationSection
    {
		string Name { get; }

		string Separator { get; }

        List<IConfigurationArgument> Arguments { get; }
    }
}
