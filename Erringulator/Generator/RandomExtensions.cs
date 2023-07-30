using System;

namespace Erringulator.Randomizer
{
    internal static class RandomExtensions
    {
        public static byte NextByte(this Random rand)
        {
            return rand.NextByte(byte.MinValue, byte.MaxValue);
        }

        public static byte NextByte(this Random rand, byte min, byte max)
        {
            return (byte)rand.Next(min, max + 1);
        }

        public static sbyte NextSByte(this Random rand, sbyte min, sbyte max)
        {
            return (sbyte)rand.Next(min, max + 1);
        }

        public static short NextShort(this Random rand, short min, short max)
        {
            return (short)rand.Next(min, max + 1);
        }

        public static ushort NextUShort(this Random rand, ushort min, ushort max)
        {
            return (ushort)rand.Next(min, max + 1);
        }

        public static float NextSingle(this Random rand, float min, float max)
        {
            return rand.NextSingle() * (max - min) + min;
        }
    }
}
