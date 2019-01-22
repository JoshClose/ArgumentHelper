using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	/// <summary>
	/// Command data.
	/// </summary>
	public class Command : ICommand
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
