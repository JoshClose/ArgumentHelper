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
		IConfigureArgument HasValue();

		/// <summary>
		/// Configure settings.
		/// </summary>
		IConfigure Configure();
	}
}
