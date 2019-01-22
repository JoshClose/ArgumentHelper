using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class ConfigureOption : IConfigureArgument
	{
		private readonly IConfigure configure;
		private readonly IOption option;

		public ConfigureOption(IConfigure configure, IOption option)
		{
			this.configure = configure;
			this.option = option;
		}

		public IConfigureArgument Description(string description)
		{
			option.Description = description;

			return this;
		}

		public IConfigureArgument HasValue()
		{
			option.HasValue = true;

			return this;
		}

		public IConfigure Configure()
		{
			return configure;
		}
	}
}
