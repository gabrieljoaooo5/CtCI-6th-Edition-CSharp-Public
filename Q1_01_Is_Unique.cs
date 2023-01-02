using System;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_01_Is_Unique
    {

        private static bool IsUniqueChars(String str)
        {
            var strArray = str.ToArray();

            for(int i = 0; i < strArray.Count() - 1; i++) {
                for (int j = i + 1; j < strArray.Count(); j++) {
                    if (strArray[i] == strArray[j]) {
                        return false;
                    }
                }
            }
            
            return true;
        }

        // From Solutions
        private static bool IsUniqueChars2(String str)
        {
            var hashset = new HashSet<char>();
            foreach(var c in str)
            {
                if (hashset.Contains(c)) return false;
                hashset.Add(c);
            }

            return true;
        }

        public static void Main(string[] args)
        {
            string[] words = { "abcde", "hello", "apple", "kite", "padle" };

            foreach (var word in words)
            {
                Console.WriteLine(word + ": " + IsUniqueChars(word) + " " + IsUniqueChars2(word));
            }
        }

    }
}

