using System.Collections.Generic;

namespace ArgumentHelper
{
	/// <summary>
	/// Configuration settings.
	/// </summary>
	public interface IConfiguration
    {
		/// <summary>
		/// Gets or sets the number of spaces before settings in usage.
		/// </summary>
		int IndentSpaces { get; set; }

		/// <summary>
		/// Gets or sets the amount of spaces that are in a tab.
		/// </summary>
		int TabSpaces { get; set; }

		/// <summary>
		/// Gets or sets the name of the program.
		/// </summary>
		string ProgramName { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		string Description { get; set; }

		string Usage { get; set; }

		List<IConfigurationSection> Sections { get; }
	}
}
