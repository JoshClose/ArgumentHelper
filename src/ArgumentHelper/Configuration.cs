using System;
using System.Collections.Generic;

namespace ArgumentHelper
{
	/// <summary>
	/// Configuration settings.
	/// </summary>
	public class Configuration : IConfiguration
	{
		/// <summary>
		/// Gets or sets the number of spaces before settings in usage.
		/// </summary>
		public int IndentSpaces { get; set; } = 2;

		/// <summary>
		/// Gets or sets the amount of spaces that are in a tab.
		/// </summary>
		public int TabSpaces { get; set; } = 8;

		public string Separator { get; set; } = "|";

		/// <summary>
		/// Gets or sets the name of the program.
		/// </summary>
		public string ProgramName { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		public string Description { get; set; }

		public string Usage { get; set; }

		public List<IConfigurationSection> Sections { get; } = new List<IConfigurationSection>();
	}
}
