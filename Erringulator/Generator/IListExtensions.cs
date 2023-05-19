using System;
using System.Collections.Generic;

namespace Erringulator.Generator
{
    internal static class IListExtensions
    {
        public static void Shuffle<T>(this IList<T> list, Random rand)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int r = rand.Next(i, list.Count);
                (list[r], list[i]) = (list[i], list[r]);
            }
        }

        public static T Pop<T>(this IList<T> list)
        {
            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }
    }
}
