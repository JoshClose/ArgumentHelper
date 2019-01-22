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
	public interface ICommand
    {
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		string Description { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance has value.
		/// </summary>
		bool HasValue { get; set; }

		/// <summary>
		/// Gets the commands.
		/// </summary>
		List<string> Commands { get; }
	}
}
