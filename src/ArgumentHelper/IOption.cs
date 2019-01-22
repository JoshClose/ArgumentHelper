using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	/// <summary>
	/// Option data.
	/// </summary>
	public interface IOption
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
		/// Gets the options.
		/// </summary>
		List<string> Options { get; }
    }
}
