using System.Collections.Generic;

namespace ArgumentHelper
{
	/// <summary>
	/// Option data.
	/// </summary>
	public class ConfigOption
	{
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance has value.
		/// </summary>
		public bool HasValue { get; set; }

		/// <summary>
		/// Gets the options.
		/// </summary>
		public List<string> Options { get; set; } = new List<string>();
	}
}
