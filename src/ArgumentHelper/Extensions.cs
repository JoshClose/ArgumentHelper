using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentHelper
{
    public static class Extensions
    {
        public static bool TryDequeue<T>(this Queue<T> queue, out T result)
		{
			var hasItems = queue.Count > 0;

			result = hasItems ? queue.Dequeue() : default;

			return hasItems;
		}

		public static bool TryPeek<T>(this Queue<T> queue, out T result)
		{
			var hasItems = queue.Count > 0;

			result = hasItems ? queue.Peek() : default;

			return hasItems;
		}
    }
}
