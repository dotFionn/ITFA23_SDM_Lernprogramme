using System;
using System.Linq;

namespace dotFionn.Checksum.Utils
{
    public static class Extensions
    {
        public static int DigitSum(this int inInt)
        {
            int digitSum = 0;

            while (inInt > 0) {
                digitSum += inInt % 10;
                inInt /= 10;
            }

            return digitSum;
        }

        public static string[] Split(this string inString)
        {
            return inString.Select(x => x.ToString()).ToArray();
        }
    }
}
