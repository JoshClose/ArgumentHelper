using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	/// <summary>
	/// Configures an argument.
	/// </summary>
	public class ConfigureArgument : IConfigureArgument
    {
		private readonly IConfigure configure;

		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigureArgument"/> class.
		/// </summary>
		/// <param name="configure">The configure.</param>
		public ConfigureArgument(IConfigure configure)
		{
			this.configure = configure;
		}

		/// <summary>
		/// Sets the description.
		/// </summary>
		/// <param name="description">The description.</param>
		public IConfigureArgument Description(string description)
		{
			return this;
		}

		/// <summary>
		/// Sets the HasValue flag to true.
		/// </summary>
		public IConfigureArgument HasValue()
		{
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
