using System;

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static int Exponential(this int e, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= e;
            }
            return result;
        }
    }
}
