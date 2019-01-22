using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public class ConfigureArgument : IConfigureArgument
    {
		private readonly IConfigure configure;

		public ConfigureArgument(IConfigure configure)
		{
			this.configure = configure;
		}

		public IConfigureArgument Description(string description)
		{
			return this;
		}

		public IConfigureArgument HasValue()
		{
			return this;
		}

		public IConfigure Configure()
		{
			return configure;
		}
	}
}
