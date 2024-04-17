using Microsoft.Extensions.Configuration;

namespace study.utils

{
    static class Utils
    {
        public static long GetMaxLength(this string[] strings)
        {
            int max = strings[0].Length;
            foreach (string s in strings)
            {
                int length = s.Length;
                max = max >= length ? max : length;
            }
            return max;
        }
    }
}