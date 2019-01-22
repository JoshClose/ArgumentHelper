namespace ArgumentHelper
{
	public interface IArgumentCollection
    {
		string this[string arg] { get; }

		bool Contains(string arg);
	}
}
