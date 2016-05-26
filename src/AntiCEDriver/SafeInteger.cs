using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AntiCEDriver
{
    public class SafeInteger
    {
        public int val1 { get; set; }
        public int[] val2 { get; set; }
        public int _rand { get; set; }

        public SafeInteger()
        {
            Random rng = new Random();
            _rand = rng.Next(0, 9);
            val1 = 0;
            val2 = new int[10];
            val2[_rand] = (val1 + _rand);
        }

        public SafeInteger(int a)
        {
            Random rng = new Random();
            _rand = rng.Next(0, 9);
            val1 = a;
            val2 = new int[10];
            val2[_rand] = (val1 + _rand);
        }

        public static SafeInteger operator +(SafeInteger a, int b)
        {
            SafeInteger n = a;

            return n;
        }
    }
}