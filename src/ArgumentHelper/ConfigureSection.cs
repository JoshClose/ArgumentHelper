using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	public class ConfigureSection : IConfigureSection
	{
		private readonly ConfigurationSection configurationSection;

		public ConfigureSection(ConfigurationSection configurationSection)
		{
			this.configurationSection = configurationSection;
		}

		public IConfigureSection Separator(string separator)
		{
			configurationSection.Separator = separator;

			return this;
		}

		public IConfigureArgument Argument(params string[] args)
		{
			var configurationArgument = new ConfigurationArgument();
			configurationArgument.Arguments.AddRange(args);

			var configureArgument = new ConfigureArgument(this, configurationArgument);

			configurationSection.Arguments.Add(configurationArgument);

			return configureArgument;
		}
	}
}
