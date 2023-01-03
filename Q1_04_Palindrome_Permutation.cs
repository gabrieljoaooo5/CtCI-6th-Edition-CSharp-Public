using System;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_04_Palindrome_Permutation
    {

        private static bool IsPalindromePermutation(string str)
        {
            str = str.ToLower();

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(var c in str) {
                if (dict.Keys.Contains(c)) {
                    dict[c] += 1;
                }
                else {
                    dict[c] = 1;
                }
            }

            var oddNumberCount = 0;
            foreach(var dictValue in dict)
            {
                if (dictValue.Value%2 != 0) {
                    oddNumberCount += 1;
                }
                if (oddNumberCount > 1) {
                    return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            String[] strings = {"Rats live on no evil star",
                            "A man, a plan, a canal, panama",
                            "Lleve",
                            "Tacotac",
                            "asda"};

            foreach (String s in strings)
            {
                bool result = IsPalindromePermutation(s);
                Console.WriteLine(s);
                Console.WriteLine("Result: " + result);
                Console.WriteLine();
            }
        }

    }
}

