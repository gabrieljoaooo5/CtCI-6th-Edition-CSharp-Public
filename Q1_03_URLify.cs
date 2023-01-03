using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter01
{
    public class Q1_03_URLify
    {

        private static string URLify(string str, int length)
        {
            var replace = "%20";
            string aux = " ";
            char space = aux.ToCharArray()[0];
            var strArray = str.ToCharArray();
            StringBuilder strBuilder = new StringBuilder();

            for(int i = 0; i < length; i++)
            {
                if (!strArray.Contains(space)) {
                    strBuilder.Append(strArray[i..^0]);
                    return strBuilder.ToString();
                }
                if (strArray[i] == space)
                {
                    strArray[i] = "-".ToCharArray()[0];
                    strBuilder.Append(replace);
                }
                else {
                    strBuilder.Append(strArray[i]);
                }
            }

            
            return strBuilder.ToString();
        }

        public static void Main(string[] args)
        {
            String[] strings = {"Rats live on no evil star",
                            "A man, a plan, a canal, panama",
                            "Mr John Smith",
                            "Tacotac",
                            "asda"};

            foreach (String s in strings)
            {
                var result = URLify(s, s.Length);
                Console.WriteLine(s);
                Console.WriteLine("Result: " + result);
                Console.WriteLine();
            }
        }
    }
}

