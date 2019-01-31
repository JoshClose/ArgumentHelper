namespace ArgumentHelper
{
	/// <summary>
	/// Configures an argument.
	/// </summary>
	public interface IConfigureArgument
	{
		/// <summary>
		/// Sets the description.
		/// </summary>
		/// <param name="description">The description.</param>
		IConfigureArgument Description(string description);

		/// <summary>
		/// Sets the HasValue flag to true.
		/// </summary>
		IConfigureArgument HasValue(string name);

		IConfigureArgument HasValues(string name, int valueCount);

		IConfigureArgument Argument(params string[] args);

		IConfigureSection Section();

		IConfigureSection Section(string name);
	}
}
