using System;

namespace ArgumentHelper
{
	/// <summary>
	/// Configures configuration settings.
	/// </summary>
	public class Configure : IConfigure
	{
		private readonly Configuration configuration;

		/// <summary>
		/// Initializes a new instance of the <see cref="Configure"/> class.
		/// </summary>
		/// <param name="configuration">The configuration.</param>
		public Configure(Configuration configuration)
		{
			this.configuration = configuration;
		}

		/// <summary>
		/// Sets the program name.
		/// </summary>
		/// <param name="programName">The program name.</param>
		public IConfigure ProgramName(string programName)
		{
			configuration.ProgramName = programName;

			return this;
		}

		/// <summary>
		/// Sets the description.
		/// </summary>
		/// <param name="description">The description.</param>
		public IConfigure Description(string description)
		{
			configuration.Description = description;

			return this;
		}

		public IConfigure Usage(string usage)
		{
			configuration.Usage = usage;

			return this;
		}

		public IConfigureSection Section() => Section(null);

		public IConfigureSection Section(string section)
		{
			var configurationSection = new ConfigurationSection
			{
				Separator = configuration.Separator
			};
			configuration.Sections.Add(configurationSection);

			var configureSection = new ConfigureSection(configurationSection);

			return configureSection;
		}
	}
}
