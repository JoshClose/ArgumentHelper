using System.Collections.Generic;

namespace ArgumentHelper
{
	/// <summary>
	/// Command data.
	/// </summary>
	public class ConfigCommand
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
		/// Gets the commands.
		/// </summary>
		public List<string> Commands { get; } = new List<string>();
	}
}
