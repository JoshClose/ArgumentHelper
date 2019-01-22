namespace ArgumentHelper
{
	/// <summary>
	/// Configure an option.
	/// </summary>
	public class ConfigureOption : IConfigureArgument
	{
		private readonly IConfigure configure;
		private readonly ConfigOption option;

		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigureOption"/> class.
		/// </summary>
		/// <param name="configure">The configure.</param>
		/// <param name="option">The option.</param>
		public ConfigureOption(IConfigure configure, ConfigOption option)
		{
			this.configure = configure;
			this.option = option;
		}

		/// <summary>
		/// Sets the description.
		/// </summary>
		/// <param name="description">The description.</param>
		public IConfigureArgument Description(string description)
		{
			option.Description = description;

			return this;
		}

		/// <summary>
		/// Sets the HasValue flag to true.
		/// </summary>
		public IConfigureArgument HasValue()
		{
			option.HasValue = true;

			return this;
		}

		/// <summary>
		/// Configure settings.
		/// </summary>
		public IConfigure Configure()
		{
			return configure;
		}
	}
}
