using System.Collections.Generic;


namespace Tree_Generics.Generic
{
    public static class Extensions
    {
        public static IEnumerable<T> Concat<T>(this T item, IEnumerable<T> collection)
        {
            yield return item;
            foreach (var _t in collection)
            {
                yield return _t;
            }
        }

    }
}
