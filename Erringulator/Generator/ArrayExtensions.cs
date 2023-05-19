using System;

namespace Erringulator.Generator
{
    internal static class ArrayExtensions
    {
        public static T Random<T>(this T[] array, Random rand)
        {
            return array[rand.Next(array.Length)];
        }
    }
}
