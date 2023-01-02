using System;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_02_Check_Permutation
    {

        private static bool CheckPermutation(String str1, String str2)
        {
            if (str1.Length != str2.Length) return false;

            var str1List = str1.ToList();
            var str2List = str2.ToList();

            for(int i = 0; i < str1.Length; i++) {

                if (!str2List.Contains(str1[i])) return false;
                str2List.Remove(str1[i]);

                if (!str1List.Contains(str2[i])) return false;
                str1List.Remove(str2[i]);
            }
            return true;
        }

        public static void Main(string[] args)
        {
            string[][] pairs =
            {
                new string[]{"apple", "papel"},
                new string[]{"carrot", "tarroc"},
                new string[]{"hello", "llloh"}
            };

            foreach (var pair in pairs)
            {
                var word1 = pair[0];
                var word2 = pair[1];
                var result = CheckPermutation(word1, word2);
                Console.WriteLine("{0}, {1}: {2}", word1, word2, result);
            }
        }

    }
}

