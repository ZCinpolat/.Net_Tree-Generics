using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Generics_002.Tree
{
    public static class Extensions
    {
        public static IEnumerable<T> Concat<T>(this T item, IEnumerable<T> collection)
        {
            yield return item;
            foreach(var t in collection)
            {
                yield return t;
            }
        }

    }
}
