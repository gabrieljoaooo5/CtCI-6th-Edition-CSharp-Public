using System;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_05_One_Array
    {

        private static bool OneArray(string str1, string str2)
        {
            if (str1.Length - str2.Length < -1 || str1.Length - str2.Length > 1) return false;

            if (str1 == str2) return true;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    int aux = 1;
                    if (str1.Length == str2.Length)
                    {
                        aux = 0;
                    }
                    else if (str1[i] != str2[i + 1])
                    {
                        aux = -1;
                    }
                    for (int j = i + 1; j < str1.Length; j++)
                    {
                        if (str1[j] != str2[j + aux])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return true;
        }

        // From Solutions
        public static bool OneEditAway(String first, String second)
        {
            /* Length checks. */
            if (Math.Abs(first.Length - second.Length) > 1)
            {
                return false;
            }

            /* Get shorter and longer string.*/
            String s1 = first.Length < second.Length ? first : second;
            String s2 = first.Length < second.Length ? second : first;

            int index1 = 0;
            int index2 = 0;
            bool foundDifference = false;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    /* Ensure that this is the first difference found.*/
                    if (foundDifference) return false;
                    foundDifference = true;
                    if (s1.Length == s2.Length)
                    { // On replace, move shorter pointer
                        index1++;
                    }
                }
                else
                {
                    index1++; // If matching, move shorter pointer
                }
                index2++; // Always move pointer for longer string
            }
            return true;
        }

        public static void Main(string[] args)
        {
            string[][] pairs =
            {
                new string[]{"pale", "ple"},
                new string[]{"pale", "pales"},
                new string[]{"pale", "bale"},
                new string[]{"pale", "bake"},
                new string[]{"apple", "aple"},
                new string[]{"aple", "apple"}
            };

            foreach (var pair in pairs)
            {
                var word1 = pair[0];
                var word2 = pair[1];
                var result = OneArray(word1, word2);
                var resultFromSolutions = OneEditAway(word1, word2);
                Console.WriteLine("{0}, {1}: {2} // {3}", word1, word2, result, resultFromSolutions);
            }
        }
    }
}

