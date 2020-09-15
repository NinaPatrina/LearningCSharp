using System;
using System.Linq;

namespace ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine(isAnagramLeetcode (s, t));
            static bool IsAnagram(string s, string t)
            {
                var s1 = s.OrderBy(c => c);
                var t1 = t.OrderBy(t => t);
                return s1.SequenceEqual(t1);
            }
            // Leetcode solution
            static bool isAnagramLeetcode(string s, string t)
            {
                if (s == null && t == null) return true;
                if (s.Length != t.Length) return false;

                int[] alphabet = new int[26];
                for (int i = 0; i < s.Length; i++) {
                    alphabet[s[i] - 'a']++;
                    Console.WriteLine(s[i]-'a' );
                        }
                
                for (int i = 0; i < t.Length; i++)
                {
                    alphabet[t[i] - 'a']--;
                    if (alphabet[t[i] - 'a'] < 0) return false;
                }
                for (int i = 0; i < 26; i++) if (alphabet[i] != 0) return false;
                return true;
            }
        }
    }
}
