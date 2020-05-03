using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class LINQExtension
    {
        public static IEnumerable<T> SnapFingers<T>(this IEnumerable<T> source)
        {
            int i = source.Count();
            int k = 0;
            int middle = (i / 2) + (i % 2);

            var newList = from element in source
                          where (k++ < middle)
                          select element;

            return newList;
        }
    }
}