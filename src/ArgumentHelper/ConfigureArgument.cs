using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class ConfigureArgument : IConfigureArgument
	{
		private readonly ConfigurationArgument configurationArgument;
		private readonly ConfigureSection configureSection;

		public ConfigureArgument(ConfigureSection configureSection, ConfigurationArgument configurationArgument)
		{
			this.configureSection = configureSection;
			this.configurationArgument = configurationArgument;
		}

		public IConfigureArgument Argument(params string[] args)
		{
			configurationArgument.Arguments.AddRange(args);

			return this;
		}

		public IConfigureArgument Description(string description)
		{
			configurationArgument.Description = description;

			return this;
		}

		public IConfigureArgument HasValue(string name)
		{
			configurationArgument.HasValues = true;
			configurationArgument.ValueName = name;

			return this;
		}

		public IConfigureArgument HasValues(string name, int valueCount)
		{
			configurationArgument.HasValues = true;
			configurationArgument.ValueName = name;
			configurationArgument.ValueCount = valueCount;

			return this;
		}

		public IConfigureSection Section()
		{
			return configureSection;
		}

		public IConfigureSection Section(string name)
		{
			return configureSection;
		}		
	}
}
