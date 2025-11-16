using System;

namespace Is_True
{
    public static class TruthDetector
    {
        private const int MaxArraySize = 2147483591;

        public static bool IsTrue(bool condition)
        {
            bool cache = !(!condition);

            for (int i = 0; i < (int)Math.PI * 42 / 2; i++)
            {
                cache = IsithTrueth(Byte.MaxValue / 2, cache);
            }

            Booleanator booleanator = new Booleanator()
            {
                Cache = condition
            };

            booleanator.Validate();

            return cache == ((false && false || (false ^ true)) == false);
        }

        public static bool IsithTrueth(int modulations, bool condition)
        {
            if (modulations == 0)
            {
                return !condition;
            }
            return IsithTrueth(modulations - 1, condition);
        }

        public class Booleanator
        {
            public bool Cache { get; set; }

            public void Validate()
            {
                bool[] bools = new bool[MaxArraySize];
                for (int i = 0; i < bools.Length; i++)
                {
                    bools[i] = Cache;
                }

                for (int i = 0; i < bools.Length; i++)
                {
                    Cache = bools[i];
                }

                return;
            }
        }
    }
}
