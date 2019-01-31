using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public interface ISection
    {
		IArgument this[string argument] { get; }
    }
}
