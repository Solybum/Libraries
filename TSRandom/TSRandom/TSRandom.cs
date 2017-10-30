using System;

namespace Libraries.ThreadSafeRandom
{
    /// <summary>
    /// https://github.com/OBeautifulCode/OBeautifulCode.Math/blob/master/OBeautifulCode.Math/ThreadSafeRandom.cs
    /// </summary>
    public static class TSRandom
    {
        /// <summary>
        /// Lock object for access to global random number generator.
        /// </summary>
        private static readonly object Lock = new object();

        /// <summary>
        /// A single random number generator
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Reseeds the random number generator.
        /// </summary>
        /// <param name="seed">
        /// A number used to calculate a starting value for the pseudo-random number sequence.
        /// If a negative number is specified, the absolute value of the number is used.
        /// </param>
        public static void Reseed(int seed)
        {
            lock (Lock)
            {
                random = new Random(seed);
            }
        }

        /// <summary>
        /// Returns a nonnegative random integer.
        /// </summary>
        /// <remarks>
        /// Random.Next generates a random number whose value ranges from zero to less than <see cref="int.MaxValue"/>.
        /// To generate a random number whose value ranges from zero to some other positive number, use the <see cref="Next(int)"/> method overload.
        /// To generate a random number within a different range, use the <see cref="Next(int,int)"/> method overload
        /// </remarks>
        /// <returns>
        /// A 32-bit signed integer greater than or equal to zero and less than MaxValue
        /// </returns>
        public static int Next()
        {
            lock (Lock)
            {
                return random.Next();
            }
        }

        /// <summary>
        /// Returns a nonnegative random integer that is less than the specified maximum.
        /// </summary>
        /// <param name="maxValue">The exclusive upper bound of the random number to be generated. maxValue must be greater than or equal to zero.</param>
        /// <returns>
        /// A 32-bit signed integer greater than or equal to zero, and less than maxValue; that is, the range of return values
        /// ordinarily includes zero but not maxValue. However, if maxValue equals zero, maxValue is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">maxValue is less than zero.</exception>
        public static int Next(int maxValue)
        {
            lock (Lock)
            {
                return random.Next(maxValue);
            }
        }

        /// <summary>
        /// Returns a random integer that is within a specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <remarks>
        /// Unlike the other overloads of the Next method, which return only non-negative values, this method can return a negative random integer.
        /// </remarks>
        /// <returns>
        /// A 32-bit signed integer greater than or equal to minValue and less than maxValue; that is, the range of
        /// return values includes minValue but not maxValue. If minValue equals maxValue, minValue is returned.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">minValue is greater than maxValue.</exception>
        public static int Next(int minValue, int maxValue)
        {
            lock (Lock)
            {
                return random.Next(minValue, maxValue);
            }
        }

        /// <summary>
        /// Fills the elements of a specified array of bytes with random numbers.
        /// </summary>
        /// <param name="buffer">An array of bytes to contain random numbers.</param>
        /// <remarks>
        /// Each element of the array of bytes is set to a random number greater than or equal to zero, and less than or equal to MaxValue.
        /// To generate a cryptographically secure random number suitable for creating a random password,
        /// for example, use a method such as RNGCryptoServiceProvider.GetBytes.
        /// </remarks>
        /// <exception cref="ArgumentNullException">buffer is null.</exception>
        public static void NextBytes(byte[] buffer)
        {
            lock (Lock)
            {
                random.NextBytes(buffer);
            }
        }

        /// <summary>
        /// Returns a random floating-point number between 0.0 and 1.0.
        /// </summary>
        /// <remarks>
        /// This method is the public version of the protected method, Sample.
        /// </remarks>
        /// <returns>
        /// A double-precision floating point number greater than or equal to 0.0, and less than 1.0.
        /// </returns>
        public static double NextDouble()
        {
            lock (Lock)
            {
                return random.NextDouble();
            }
        }
    }
}
