using System;
using System.Collections;

namespace LValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "({([()dfgfg])}){sdfdsf}()[df]sd";
            Stack st = new Stack();
            char b=' ';
            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];
                if (a == '(' || a == ')' || a == '{' || a == '}' || a == '[' || a == ']')
                {
                    if (a == b) st.Pop();
                    else
                    {
                        st.Push(a);
                    }
                    if (st.Count >= 1)
                    {
                        if (st.Peek().ToString() == "(") b = ')';
                        if (st.Peek().ToString() == "{") b = '}';
                        if (st.Peek().ToString() == "[") b = ']';
                    }
                }
            }
            foreach (var elem in st)
            {
                Console.WriteLine(elem);
            }
            if (st.Count!=0)
            {
                return false;
            }
            else
                return true;


            //    string parentheses = ("({[()]}[]");
            //    Console.WriteLine(IsValid(parentheses));
            //}
            //static bool IsValid(string s)
            //{
            //    string v;
            //    do
            //    {   v = s;
            //        s = NewString(s);
            //    }
            //    while (v != s);

            //Console.WriteLine(s);
            //if (s != "")
            //    return false;
            //return true;
            //}
            //static string NewString(string s)
            //{
            //    for (int i = 0; i < s.Length - 1; i++)
            //    {
            //        if (s[i] == '(' && s[i + 1] == ')')
            //        {
            //            s = s.Remove(i, 1);
            //            s = s.Remove(i, 1);
            //            return s;
            //        }
            //        if (s[i] == '{' && s[i + 1] == '}')
            //        {
            //            s = s.Remove(i, 1);
            //            s = s.Remove(i, 1);
            //            return s;
            //        }

            //        if (s[i] == '[' && s[i + 1] == ']')
            //        {
            //            s = s.Remove(i, 1);
            //            s = s.Remove(i, 1);
            //            return s;
            //        }
            //    }
            //    return s;
        }
    }
}