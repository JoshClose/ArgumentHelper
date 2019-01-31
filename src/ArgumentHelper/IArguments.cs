using System.Collections.Generic;

namespace ArgumentHelper
{
	/// <summary>
	/// Configured arguments.
	/// </summary>
	public interface IArguments
    {
		ISection this[string section] { get; }
    }
}
