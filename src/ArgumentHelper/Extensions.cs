using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
	/// <summary>
	/// Extension methods.
	/// </summary>
	public static class Extensions
    {
		/// <summary>
		/// Tries the dequeue.
		/// </summary>
		/// <typeparam name="T">Queue type.</typeparam>
		/// <param name="queue">The queue.</param>
		/// <param name="result">The result.</param>
		public static bool TryDequeue<T>(this Queue<T> queue, out T result)
		{
			var hasItems = queue.Count > 0;

			result = hasItems ? queue.Dequeue() : default;

			return hasItems;
		}

		/// <summary>
		/// Tries the peek.
		/// </summary>
		/// <typeparam name="T">Queue type.</typeparam>
		/// <param name="queue">The queue.</param>
		/// <param name="result">The result.</param>
		public static bool TryPeek<T>(this Queue<T> queue, out T result)
		{
			var hasItems = queue.Count > 0;

			result = hasItems ? queue.Peek() : default;

			return hasItems;
		}
    }
}
