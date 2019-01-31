namespace ArgumentHelper
{
	/// <summary>
	/// Configures configuration settings.
	/// </summary>
	public interface IConfigure
    {
		/// <summary>
		/// Sets the program name.
		/// </summary>
		/// <param name="programName">The program name.</param>
		IConfigure ProgramName(string programName);

		/// <summary>
		/// Sets the description.
		/// </summary>
		/// <param name="description">The description.</param>
		IConfigure Description(string description);

		IConfigure Usage(string usage);

		IConfigureSection Section();

		IConfigureSection Section(string section);
	}
}
