using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    public class HandlesStrings
    {
     public void ReverseStringMethod1(string inputString) {
           
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            Console.WriteLine($"Reversed string: {reversedString}");
      }

     public void ReverseStringMethod2(string inputString) {

            Console.WriteLine("Reversed string: ");
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputString[i]);
            }
            Console.WriteLine();
      }

    public string ReverseSentence(string str)
        {
            HashSet<char> parts = new HashSet<char> { '.', ',', ':', ';', '=', '(', ')', '&','[',']', '"', '\'', '\\' , '/', '!', '?', ' '};
            List<string> arr = new List<string>();
            string temp = "";

            int i = 0;
            while(i < str.Length)
            {
                while (i < str.Length && !parts.Contains(str[i]))
                {
                    temp += str[i];
                    i++;
                }
                if(temp.Length > 0)
                    arr.Add(temp);
                temp = "";
                while (i < str.Length && parts.Contains(str[i]))
                {
                    temp += str[i];
                    i++;
                }
                if (temp.Length > 0)
                    arr.Add(temp);
                temp = "";
            }

            string[] merged = arr.ToArray();

            int j = 0;
            int k = merged.Length - 1;

            while (j < k)
            {
                while (j < k && parts.Contains(merged[j][0])) j++;
                while (j < k && parts.Contains(merged[k][0])) k--;

                string t = merged[j];
                merged[j] = merged[k];
                merged[k] = t;
                j++;
                k--;
            }

            string ans = "";
            foreach(string m in merged) {
                ans += m;
            }
            return ans;   
        }

        public string[] GetPalindrome(string str)
        {
            string[] temp = HandlesStrings.GetStringArr(str);
            
            List<string> arr = new List<string>();

            for(int i = 0; i < temp.Length; i++)
            {
                if (IsPalindrome(temp[i]))
                {
                    arr.Add(temp[i]);
                }
            }

            arr.Sort();
            return arr.ToArray();
        }

     private static bool IsPalindrome(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1]) return false;
            }
            return true;
        }
     private static string[] GetStringArr(string str) {
            Regex regex = new Regex(@"[.,:;=\(\)&\[\]""'\\\/!?\s]");
            string[] words = regex.Split(str).Where(s => !string.IsNullOrEmpty(s)).ToArray();
            return words;
     }

        public string[] ParseURL(string url)
        {
            Regex regex = new Regex(@"^(?:([\w]+)://)?([^/]+)(?:/(.*))?$");
            Match match = regex.Match(url);

            if (match.Success)
            {
                string protocol = match.Groups[1].Value;
                string server = match.Groups[2].Value;
                string resource = match.Groups[3].Value;

                return new string[] { protocol, server, resource };
            }

            return new string[] {};
        }

    }
}
