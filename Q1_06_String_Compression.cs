using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter01
{
    public class Q1_06_String_Compression
    {

        private static string StringCompression(string str)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(str[0]);
            var countLetters = 1;

            for(int i = 1; i < str.Length; i++)
            {
                if(str[i] == strBuilder[strBuilder.Length-1])
                {
                    countLetters+=1;
                }
                else{
                    strBuilder.Append(countLetters);
                    strBuilder.Append(str[i]);
                    countLetters = 1;
                }
            }
            strBuilder.Append(countLetters);

            if (strBuilder.ToString().Length > str.Length) return str;
            return strBuilder.ToString();
        }

        

        public static void Main(string[] args)
        {
            string[] strings = {"aaabbbccdddeeeff", "abcdefghijl", "aaaBBaaaCCCd"};

            foreach (var str in strings)
            {
                var result = StringCompression(str);
                Console.WriteLine("{0}: {1}", str, result);
            }
        }
    }
}

