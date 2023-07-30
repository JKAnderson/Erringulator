using System;

namespace Erringulator.Randomizer
{
    internal static class ArrayExtensions
    {
        public static T Random<T>(this T[] array, Random rand)
        {
            return array[rand.Next(array.Length)];
        }
    }
}
