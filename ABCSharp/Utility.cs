﻿using System;
using System.IO;

namespace ABCSharp
{
    public static class Utility
    {
        /// <summary>
        /// Swaps values of two variables
        /// </summary>
        public static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Attempts to read int number from console. Unsafe.
        /// </summary>
        public static int ReadInt() =>
            int.Parse(Console.ReadLine());

		/// <summary>
		/// Attempts to read two consecutive ints from console
		/// </summary>
		/// <returns>Tuple of two ints</returns>
	    public static (int, int) ReadInt2()
	    {
		    try
		    {
			    var input = Console.ReadLine().Split();
			    return (int.Parse(input[0]), int.Parse(input[1]));
		    }
		    catch
		    {
				throw new IOException();
		    }
	    }

        /// <summary>
        /// Attempts to read integer from console. Returns true if succeeded, false otherwise.
        /// </summary>
        public static bool TryReadInt(out int result)
        {
            try
            {
                result = ReadInt();
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }

        /// <summary>
        /// Attempts to read double from console. Unsafe.
        /// </summary>
        public static double ReadDouble() =>
            double.Parse(Console.ReadLine());

		/// <summary>
		/// Attempts to read two consecutive double numbers from console
		/// </summary>
	    public static (double, double) ReadDouble2()
	    {
		    try
		    {
			    var input = Console.ReadLine().Split();
			    return (double.Parse(input[0]), double.Parse(input[1]));
		    }
		    catch
		    {
				throw new IOException();
		    }
	    }

        /// <summary>
        /// Attempts to read double from console. Returns true if succeeded, false otherwise.
        /// </summary>
        public static bool TryReadDouble(out double result)
        {
            try
            {
                result = ReadDouble();
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }

        /// <summary>
        /// Creates temp-name for file
        /// </summary>
        public static string GetTempName(string path, string postfix = "-temp")
        {
            var ext = Path.GetExtension(path);
            var directory = Path.GetDirectoryName(path);
            var filename = Path.GetFileNameWithoutExtension(path);
            return Path.Combine(directory, filename + postfix + ext);
        }
    }
}